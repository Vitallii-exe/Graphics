using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_work
{
    partial class MainForm
    {
        private void ClickLayerButtonUp(object sender, EventArgs e)
        {
            if (сurrentLayerIndex + 1 < workLayerList.Count)
            {
                Layer Buff = workLayerList[сurrentLayerIndex + 1];
                workLayerList[сurrentLayerIndex + 1] = workLayerList[сurrentLayerIndex];
                workLayerList[сurrentLayerIndex] = Buff;
                сurrentLayerIndex++;
                LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref layerPanel);
                for (int i = 0; i < workLayerList.Count; i++) workLayerList[i].preview.Tag = i;
                workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
                workSpace.Refresh();

                Scale.Value = workLayerList[сurrentLayerIndex].scale;
                scaleLabel.Text = String.Format("{0} %", Scale.Value);
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
                LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref layerPanel);
                for (int i = 0; i < workLayerList.Count; i++) workLayerList[i].preview.Tag = i;
                workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
                workSpace.Refresh();

                Scale.Value = workLayerList[сurrentLayerIndex].scale;
                scaleLabel.Text = String.Format("{0} %", Scale.Value);
            }
        }

        private void AddLayer(Bitmap pieceToNewLayer = null) {
            Layer creatingVoidLayer = new Layer();
            Bitmap orig;
            if (pieceToNewLayer != null) orig = pieceToNewLayer;
            else orig = new Bitmap(workSpace.Width, workSpace.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            creatingVoidLayer.original = orig;
            if (сurrentLayerIndex + 1 < workLayerList.Count)
            {
                workLayerList.Insert(сurrentLayerIndex + 1, creatingVoidLayer);
                сurrentLayerIndex = сurrentLayerIndex + 1;
            }

            else
            {
                workLayerList.Add(creatingVoidLayer);
                сurrentLayerIndex = workLayerList.Count - 1;
            }

            workLayerList[сurrentLayerIndex].isVisibleCheckbox.Click += new System.EventHandler(UpdateVisualLayers);
            workLayerList[сurrentLayerIndex].preview.Tag = сurrentLayerIndex;
            workLayerList[сurrentLayerIndex].preview.Click += new System.EventHandler(UpdateActiveLayer);
            workLayerList[сurrentLayerIndex].activeInstrument = (int)Instruments.BrushDraw;
            workLayerList[сurrentLayerIndex].layerPen.Color = Color.FromArgb((int)((float)TransparencyUpDown.Value * 2.55), colorButtonChoose.BackColor);
            LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref layerPanel);

            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            workSpace.Refresh();

        }

        private void ClickAddLayerButton(object sender, EventArgs e) {
            AddLayer();
        }

        private void ClickLayerDeleteButton(object sender, EventArgs e)
        {
            workLayerList.Remove(workLayerList[сurrentLayerIndex]);
            сurrentLayerIndex = workLayerList.Count - 1;
            LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref layerPanel);
            for (int i = 0; i < workLayerList.Count; i++) workLayerList[i].preview.Tag = i;
            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            workSpace.Refresh();
        }
    }
}
