using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_work
{
    public partial class LayerVisualiser : UserControl
    {
        public LayerVisualiser()
        {
            InitializeComponent();
        }

        public static void UpdateLayersPreviews(ref List<Layer> workLayerList, ref Panel layerPanel, ref int currentLayerPosition)
        {
            for (int i = 0; i < workLayerList.Count; i++)
            {
                int reversedNumber = workLayerList.Count - i - 1;
                workLayerList[i].preview.Size = new Size(80, 50);
                workLayerList[i].preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                workLayerList[i].isVisibleCheckbox.Checked = workLayerList[i].isVisible;

                workLayerList[i].preview.Location = new Point(20, reversedNumber * 60);
                workLayerList[i].isVisibleCheckbox.Location = new Point(5, reversedNumber * 60 + 15);
                workLayerList[i].labelCaption.Location = new Point(120, reversedNumber * 60 + 15);

                if (currentLayerPosition == i)
                {
                    workLayerList[i].labelCaption.Text = "Слой " + i.ToString() + " (Активный)";
                }
                else workLayerList[i].labelCaption.Text = "Слой " + i.ToString();

                workLayerList[i].preview.BackgroundImage = workLayerList[i].original;
            }
            layerPanel.Refresh();
        }

        public static void AddVisualLayer(ref List<Layer> workLayerList, ref int currentLayerIndex, ref Panel layerPanel)
        {
            layerPanel.Controls.Clear();
            UpdateLayersPreviews(ref workLayerList, ref layerPanel, ref currentLayerIndex);
            for (int i = 0; i < workLayerList.Count; i++)
            {
                layerPanel.Controls.Add(workLayerList[i].preview);
                layerPanel.Controls.Add(workLayerList[i].isVisibleCheckbox);
                layerPanel.Controls.Add(workLayerList[i].labelCaption);

                layerPanel.Refresh();
            }
        }
    }
}
