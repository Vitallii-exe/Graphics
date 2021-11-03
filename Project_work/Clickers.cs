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
                LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref layerPanel);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Export.ExportToFile(ref workLayerList, ref сurrentLayerIndex);
        }

        public void MovingInstrClick(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            this.Cursor = Cursors.SizeAll;
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Move;
        }

        private void BrushClick(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.BrushDraw;
            workLayerList[сurrentLayerIndex].layerPen.Color = Color.FromArgb((int)((float)TransparencyUpDown.Value * 2.55), colorButtonChoose.BackColor);
        }

        private void CreateAreaClick(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Select;
        }

        private void EraserButtonClick(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Eraser;
        }

        private void CroppingClick(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Cut;
        }

        private void ClickPipette(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.Pipitte;
        }

        private void ClickChooseColorButton(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            if (colorChoose.ShowDialog() == DialogResult.OK)
            {
                workLayerList[сurrentLayerIndex].layerPen.Color = Color.FromArgb((int)((float)TransparencyUpDown.Value * 2.55), colorChoose.Color);
                colorButtonChoose.BackColor = colorChoose.Color;
            }
        }

        private void ClickApplyButton(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
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
            if (!CheckCorrectIndexAndBitmap()) return;
            ColorCorrection ColorCorrForm = new ColorCorrection(ref workLayerList[сurrentLayerIndex].original);
            ColorCorrForm.ShowDialog();
            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref layerPanel, ref сurrentLayerIndex);
            workSpace.Refresh();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }


        private void ClickColorBalanceButton(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            ColorBalancing ColorBalForm = new ColorBalancing(ref workLayerList[сurrentLayerIndex].original);
            ColorBalForm.ShowDialog();
            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref layerPanel, ref сurrentLayerIndex);
            workSpace.Refresh();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
    }
}
