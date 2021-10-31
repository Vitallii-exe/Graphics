using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_work
{
    partial class MainForm
    {
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Export.ImportFromFile(ref workLayerList, ref workSpace);
            LayerVisualiser currentLayerVisualiser = new LayerVisualiser();
            сurrentLayerIndex = workLayerList.Count - 1;
            for (int i = 0; i < workLayerList.Count; i++)
            {
                workLayerList[i].isVisibleCheckbox.Click += new System.EventHandler(UpdateVisualLayers);
                workLayerList[i].preview.Tag = i;
                workLayerList[i].preview.Click += new System.EventHandler(UpdateActiveLayer);
                LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref Layer_panel);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Export.ExportToFile(ref workLayerList, ref сurrentLayerIndex);
        }

        public void MovingInstrClick(object sender, EventArgs e)
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
            }
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
