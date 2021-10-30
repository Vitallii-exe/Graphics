using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_work
{
    public partial class Form1 : Form
    {
        enum Instruments { Move, Select, Cut, BrushDraw, Pipitte, Eraser };
        enum States { WaitToAccept };
        List<Layer> workLayerList = new List<Layer>();
        int сurrentLayerIndex = 0;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            new LayerVisualiser();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Export.ImportFromFile(ref workLayerList, ref workSpace);
            LayerVisualiser currentLayerVisualiser = new LayerVisualiser();
            сurrentLayerIndex = workLayerList.Count - 1;
            for (int i = 0; i < workLayerList.Count; i++) {
                workLayerList[i].isVisibleCheckbox.Click += new System.EventHandler(UpdateVisualLayers);
                workLayerList[i].preview.Tag = i;
                workLayerList[i].preview.Click += new System.EventHandler(UpdateActiveLayer);
                LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref Layer_panel);
            }
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
            сurrentLayerIndex = (int)from_sender.Tag;
            //LayerVisualiser.AddVisualLayer(ref work_layer_list, ref CurrentLayerIndex, ref Layer_panel, ref Work_space);
            LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref Layer_panel, ref сurrentLayerIndex);
            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            workSpace.Refresh();
            Scale.Value = workLayerList[сurrentLayerIndex].scale;
            Scale_label.Text = String.Format("{0} %", Scale.Value);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Export.ExportToFile(ref workLayerList, ref сurrentLayerIndex);
        }

        private void MovingInstrClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Move;
        }

        private void BrushClick(object sender, EventArgs e)
        {
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.BrushDraw;
            workLayerList[сurrentLayerIndex].layerPen.Color = choose_color_button.BackColor;
        }

        private void CreateAreaClick(object sender, EventArgs e)
        {
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Select;
        }

        private void EraserButtonClick(object sender, EventArgs e)
        {
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Eraser;
        }

        private void CroppingClick(object sender, EventArgs e)
        {
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Cut;
        }

        private void ClickPipette(object sender, EventArgs e)
        {
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Pipitte;
        }

        private void ClickLayerButtonUp(object sender, EventArgs e)
        {
            if (сurrentLayerIndex + 1 < workLayerList.Count)
            {
                Layer Buff = workLayerList[сurrentLayerIndex + 1];
                workLayerList[сurrentLayerIndex + 1] = workLayerList[сurrentLayerIndex];
                workLayerList[сurrentLayerIndex] = Buff;
                сurrentLayerIndex++;
                LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref Layer_panel);
                for (int i = 0; i < workLayerList.Count; i++)  workLayerList[i].preview.Tag = i;
                workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
                workSpace.Refresh();

                Scale.Value = workLayerList[сurrentLayerIndex].scale;
                Scale_label.Text = String.Format("{0} %", Scale.Value);
            }

        }

        private void ClickLayerButtonDown(object sender, EventArgs e)
        {
            if (сurrentLayerIndex - 1 > -1)
            {
                Layer Buff = workLayerList[сurrentLayerIndex - 1];
                workLayerList[сurrentLayerIndex - 1] = workLayerList[сurrentLayerIndex];
                workLayerList[сurrentLayerIndex] = Buff;
                сurrentLayerIndex -= 1;
                LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref Layer_panel);
                for (int i = 0; i < workLayerList.Count; i++) workLayerList[i].preview.Tag = i;
                workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
                workSpace.Refresh();

                Scale.Value = workLayerList[сurrentLayerIndex].scale;
                Scale_label.Text = String.Format("{0} %", Scale.Value);
            }
        }

        private void ClickChooseColorButton(object sender, EventArgs e)
        {
            if (Choose_color.ShowDialog() == DialogResult.OK)
            {
                workLayerList[сurrentLayerIndex].layerPen.Color = Choose_color.Color;
                choose_color_button.BackColor = Choose_color.Color;
            }
        }

        private void ClickApplyButton(object sender, EventArgs e)
        {
            if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Cut
                & workLayerList[сurrentLayerIndex].currentState == (int)States.WaitToAccept)
            {
                Bitmap to_draw = workLayerList[сurrentLayerIndex].ResizeBitmap(workLayerList[сurrentLayerIndex].original, workSpace.Width, workSpace.Height,
                                                               workLayerList[сurrentLayerIndex].original.Width * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].original.Height * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].shift.X, workLayerList[сurrentLayerIndex].shift.Y);

                workLayerList[сurrentLayerIndex].original = workLayerList[сurrentLayerIndex].CropBitmap(to_draw, workLayerList[сurrentLayerIndex].selection);
                workLayerList[сurrentLayerIndex].shift = new Point(0, 0);
                workLayerList[сurrentLayerIndex].scale = 100;
                Scale.Value = 100;

                workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
                workSpace.Refresh();
                //Layer.AddVisualLayer(ref work_layer_list, ref CurrentLayerIndex, ref Layer_panel, ref Work_space);
            }
        }

        private void MouseDownWorkSpace(object sender, MouseEventArgs e)
        {
            Point relative_current_position = new Point((e.Location.X - workLayerList[сurrentLayerIndex].shift.X) * 100 / workLayerList[сurrentLayerIndex].scale,
                                                            (e.Location.Y - workLayerList[сurrentLayerIndex].shift.Y) * 100 / workLayerList[сurrentLayerIndex].scale);
            if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select
                | workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Cut)
            {
                workLayerList[сurrentLayerIndex].startPositionSelection = e.Location;
                return;
            }


            else if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.BrushDraw)
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
                workLayerList[сurrentLayerIndex].layerPen.Color = pipette.BackColor;
                choose_color_button.BackColor = pipette.BackColor;
                workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.BrushDraw;
                toolTip1.Show("Цвет выбран!", pipette, 1000);
            }

        }

        private void MouseMoveWorkSpace(object sender, MouseEventArgs e)
        {
            if (сurrentLayerIndex < workLayerList.Count)
            {
                Point relative_current_position = new Point((e.Location.X - workLayerList[сurrentLayerIndex].shift.X) * 100 / workLayerList[сurrentLayerIndex].scale, (e.Location.Y - workLayerList[сurrentLayerIndex].shift.Y) * 100 / workLayerList[сurrentLayerIndex].scale);
                if (e.Button == System.Windows.Forms.MouseButtons.Left & workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Eraser)
                {
                    for (int i = relative_current_position.X - 5; i < relative_current_position.X + 5; i++)
                    {
                        for (int j = relative_current_position.Y - 5; j < relative_current_position.Y + 5; j++)
                        {
                            workLayerList[сurrentLayerIndex].original.SetPixel(i, j, Color.Transparent);
                        }
                    }
                    workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
                    LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref Layer_panel, ref сurrentLayerIndex);
                    workSpace.Refresh();
                    return;
                }

                if (e.Button == System.Windows.Forms.MouseButtons.Left & workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.BrushDraw)
                {
                    toolTip1.Hide(pipette);
                    workLayerList[сurrentLayerIndex].original = Layer.BrushDraw(ref workLayerList[сurrentLayerIndex].original, ref workLayerList[сurrentLayerIndex].layerPen, ref workLayerList[сurrentLayerIndex].lastPosition, ref relative_current_position);
                    workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
                    workLayerList[сurrentLayerIndex].lastPosition = relative_current_position;
                    LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref Layer_panel, ref сurrentLayerIndex);
                    workSpace.Refresh();
                    return;
                }

                else if ((workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select
                         | workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Cut) & e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if (workLayerList[сurrentLayerIndex].original != null)
                        workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);

                    workLayerList[сurrentLayerIndex].selection = workLayerList[сurrentLayerIndex].GetSelRectangle(workLayerList[сurrentLayerIndex].startPositionSelection, e.Location);
                    using (Graphics g = Graphics.FromImage(workSpace.Image))
                        g.DrawRectangle(workLayerList[сurrentLayerIndex].selectionPen, workLayerList[сurrentLayerIndex].selection);
                    workSpace.Refresh();
                    LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref Layer_panel, ref сurrentLayerIndex);
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
                    if (workLayerList[сurrentLayerIndex].original != null) {
                       Color cutted_color = ((Bitmap)workSpace.Image).GetPixel(e.Location.X, e.Location.Y);
                        pipette.BackColor = cutted_color;
                    }
                    return;
                }
            }
        }

        private void ScrollScale(object sender, EventArgs e)
        {
            Scale_label.Text = String.Format("{0} %", Scale.Value);
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
            workLayerList[сurrentLayerIndex].layerPen.Width = (float)opacity_UpDown.Value;
        }

        private void ClickColorCorrectionButton(object sender, EventArgs e)
        {
            ColorCorrection ColorCorrForm = new ColorCorrection(ref workLayerList[сurrentLayerIndex].original);
            ColorCorrForm.ShowDialog();
            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref Layer_panel, ref сurrentLayerIndex);
            workSpace.Refresh();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void ClickColorBalanceButton(object sender, EventArgs e)
        {
            ColorBalancing ColorBalForm = new ColorBalancing(ref workLayerList[сurrentLayerIndex].original);
            ColorBalForm.ShowDialog();
            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref Layer_panel, ref сurrentLayerIndex);
            workSpace.Refresh();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
    }
}
