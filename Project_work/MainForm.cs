using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_work
{
    public partial class MainForm : Form
    {
        public enum Instruments { Move, Select, Cut, BrushDraw, Pipitte, Eraser };
        public enum States { WaitToAccept };
        public List<Layer> workLayerList = new List<Layer>();
        public int сurrentLayerIndex = 0;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            new LayerVisualiser();
        }

        private bool CheckCorrectIndexAndBitmap() {
            if (сurrentLayerIndex > workLayerList.Count - 1)
            {
                return false;
            }

            else if (сurrentLayerIndex < 0)
            {
                return false;
            }

            else if (workLayerList[сurrentLayerIndex].original == null)
            {
                return false;
            }
            return true;
        }

        private void UpdateVisualLayers(object sender, EventArgs e)
        {
            for (int i = 0; i < workLayerList.Count; i++)
            {
                if (workLayerList[i].isVisible != workLayerList[i].isVisibleCheckbox.Checked)
                {
                    workLayerList[i].isVisible = workLayerList[i].isVisibleCheckbox.Checked;
                }
            }
            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            workSpace.Refresh();
        }

        private void UpdateActiveLayer(object sender, EventArgs e) {
            Button from_sender = sender as Button;
            if (!CheckCorrectIndexAndBitmap()) return;
            сurrentLayerIndex = (int)from_sender.Tag;
            LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref layerPanel, ref сurrentLayerIndex);
            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            workSpace.Refresh();
            Scale.Value = workLayerList[сurrentLayerIndex].scale;
            scaleLabel.Text = String.Format("{0} %", Scale.Value);
        }

        private void MouseDownWorkSpace(object sender, MouseEventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            Point relative_current_position = new Point((e.Location.X - workLayerList[сurrentLayerIndex].shift.X) * 100 / workLayerList[сurrentLayerIndex].scale,
                                                            (e.Location.Y - workLayerList[сurrentLayerIndex].shift.Y) * 100 / workLayerList[сurrentLayerIndex].scale);
            if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select
                | workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Cut)
            {
                workLayerList[сurrentLayerIndex].startPositionSelection = e.Location;
                return;
            }


            else if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.BrushDraw 
                    | workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Eraser)
            {
                workLayerList[сurrentLayerIndex].lastPosition = relative_current_position;
                return;
            }

            else if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Move)
            {
                workLayerList[сurrentLayerIndex].startPosition = Cursor.Position;
                return;
            }
        }

        private void MouseUpWorkSpace(object sender, MouseEventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.contextPicBox.Show(Cursor.Position.X, Cursor.Position.Y);
            }
            else if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select
                     | workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Cut)
            {
                workLayerList[сurrentLayerIndex].currentState = (int)States.WaitToAccept;

                Pen finished_selection_pen = workLayerList[сurrentLayerIndex].selectionPen;
                switch (workLayerList[сurrentLayerIndex].activeInstrument) {
                    case (int)Instruments.Cut:
                        finished_selection_pen.Brush = Brushes.Red;
                        break;
                    case (int)Instruments.Select:
                        finished_selection_pen.Brush = Brushes.Lime;
                        break;
                }
                using (Graphics g = Graphics.FromImage(workSpace.Image))
                    g.DrawRectangle(finished_selection_pen, workLayerList[сurrentLayerIndex].selection);

                workSpace.Refresh();
            }

            else if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Move)
            {
                workLayerList[сurrentLayerIndex].shift = workLayerList[сurrentLayerIndex].shiftTmp;
            }
            else if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Pipitte) {
                workLayerList[сurrentLayerIndex].layerPen.Color = Color.FromArgb((int)((float)TransparencyUpDown.Value * 2.55), pipette.BackColor);
                colorButtonChoose.BackColor = pipette.BackColor;
                workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.BrushDraw;
                toolTip1.Show("Цвет выбран!", pipette, 700);
            }

        }
        private void MouseMoveWorkSpace(object sender, MouseEventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;

            Point relativeCurrentPosition = new Point((e.Location.X - workLayerList[сurrentLayerIndex].shift.X) * 100 / workLayerList[сurrentLayerIndex].scale, (e.Location.Y - workLayerList[сurrentLayerIndex].shift.Y) * 100 / workLayerList[сurrentLayerIndex].scale);

                if (e.Button == System.Windows.Forms.MouseButtons.Left & (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.BrushDraw
                    | workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Eraser))
                {
                    toolTip1.Hide(pipette);
                    if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Eraser)
                    {
                        workLayerList[сurrentLayerIndex].original = Layer.BrushDraw(ref workLayerList[сurrentLayerIndex].original, ref workLayerList[сurrentLayerIndex].eraserPen, ref workLayerList[сurrentLayerIndex].lastPosition, ref relativeCurrentPosition, true);
                    }

                    else
                    {
                        workLayerList[сurrentLayerIndex].original = Layer.BrushDraw(ref workLayerList[сurrentLayerIndex].original, ref workLayerList[сurrentLayerIndex].layerPen, ref workLayerList[сurrentLayerIndex].lastPosition, ref relativeCurrentPosition);
                    }
                    workLayerList[сurrentLayerIndex].lastPosition = relativeCurrentPosition;
                    workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
                    LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref layerPanel, ref сurrentLayerIndex);
                    workSpace.Refresh();
                    return;
                }

                else if ((workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select
                         | workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Cut) 
                         & e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if (workLayerList[сurrentLayerIndex].original != null)
                        workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);

                    Rectangle currentSelection = workLayerList[сurrentLayerIndex].GetSelRectangle(workLayerList[сurrentLayerIndex].startPositionSelection, e.Location);
                if (currentSelection.X < workSpace.Location.X) currentSelection.X = workSpace.Location.X;
                if (currentSelection.Y < workSpace.Location.Y) currentSelection.Y = workSpace.Location.Y;
                if (currentSelection.Y + currentSelection.Height > workSpace.Location.Y + workSpace.Height) currentSelection.Height = workSpace.Height - currentSelection.Y;
                if (currentSelection.X + currentSelection.Width > workSpace.Location.X + workSpace.Width) currentSelection.Width = workSpace.Width - currentSelection.X;
                    workLayerList[сurrentLayerIndex].selection = currentSelection;

                    using (Graphics g = Graphics.FromImage(workSpace.Image))
                        g.DrawRectangle(workLayerList[сurrentLayerIndex].selectionPen, workLayerList[сurrentLayerIndex].selection);
                    workSpace.Refresh();
                    LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref layerPanel, ref сurrentLayerIndex);
                    return;
                }

                else if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Move)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left & workLayerList[сurrentLayerIndex].original != null)
                    {
                        workLayerList[сurrentLayerIndex].shiftTmp.X = Cursor.Position.X - workLayerList[сurrentLayerIndex].startPosition.X + workLayerList[сurrentLayerIndex].shift.X;
                        workLayerList[сurrentLayerIndex].shiftTmp.Y = Cursor.Position.Y - workLayerList[сurrentLayerIndex].startPosition.Y + workLayerList[сurrentLayerIndex].shift.Y;
                        workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace, true);

                        workSpace.Refresh();

                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                    }
                    return;
                }
                else if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Pipitte) {
                       Color cutted_color = ((Bitmap)workSpace.Image).GetPixel(e.Location.X, e.Location.Y);
                        pipette.BackColor = cutted_color;
                    return;
                }
            
        }

        private void ScrollScale(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            scaleLabel.Text = String.Format("{0} %", Scale.Value);
            workLayerList[сurrentLayerIndex].scale = Scale.Value + 1;
            if (workLayerList[сurrentLayerIndex].original != null)
                workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);

            workSpace.Refresh();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void ChangeValueWidthUpDown(object sender, EventArgs e)
        {
            this.workSpace.Size = new System.Drawing.Size((int)WidthUpDown.Value, (int)HeightUpDown.Value);
            workSpace.Refresh();
        }

        private void ChangeValueHeightUpDown(object sender, EventArgs e)
        {
            workSpace.Size = new System.Drawing.Size((int)WidthUpDown.Value, (int)HeightUpDown.Value);
            workSpace.Refresh();
        }

        private void ChangeValueOpacityUpDown(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            workLayerList[сurrentLayerIndex].layerPen.Width = (float)opacity_UpDown.Value;
            workLayerList[сurrentLayerIndex].eraserPen.Width = (float)opacity_UpDown.Value;
        }

        private void ChangeValueTransparencyUpDown(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            workLayerList[сurrentLayerIndex].layerPen.Color = Color.FromArgb((int)((float)TransparencyUpDown.Value * 2.55), workLayerList[сurrentLayerIndex].layerPen.Color);
        }

        private void KeyPressMainForm(object sender, KeyPressEventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            if (e.KeyChar == 3) CopyLayerToClipboard();
            if (e.KeyChar == 24) CutLayerToClipboard();
        }
    }
}
