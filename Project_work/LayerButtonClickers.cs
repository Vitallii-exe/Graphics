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
                LayerVisualiser.AddVisualLayer(ref workLayerList, ref сurrentLayerIndex, ref Layer_panel);
                for (int i = 0; i < workLayerList.Count; i++) workLayerList[i].preview.Tag = i;
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
    }
}
