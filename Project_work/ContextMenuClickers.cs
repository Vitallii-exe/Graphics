using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_work
{
    partial class MainForm
    {
        private void CopyToNewLayerContextClick(object sender, EventArgs e)
        {
            if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select & workLayerList[сurrentLayerIndex].currentState == (int)States.WaitToAccept) {
                Bitmap to_draw = workLayerList[сurrentLayerIndex].ResizeBitmap(workLayerList[сurrentLayerIndex].original, workSpace.Width, workSpace.Height,
                                                               workLayerList[сurrentLayerIndex].original.Width * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].original.Height * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].shift.X, workLayerList[сurrentLayerIndex].shift.Y);
                if (!workLayerList[сurrentLayerIndex].selection.IsEmpty)
                {
                    int lastIndex = сurrentLayerIndex;
                    AddLayer(workLayerList[сurrentLayerIndex].CropBitmap(to_draw, workLayerList[сurrentLayerIndex].selection));
                    workLayerList[lastIndex].selection = new Rectangle(0, 0, 0, 0);
                }
            }
        }

        private void CutToNewLayerContextClick(object sender, EventArgs e)
        {
            if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select & workLayerList[сurrentLayerIndex].currentState == (int)States.WaitToAccept)
            {
                Bitmap to_draw = workLayerList[сurrentLayerIndex].ResizeBitmap(workLayerList[сurrentLayerIndex].original, workSpace.Width, workSpace.Height,
                                                               workLayerList[сurrentLayerIndex].original.Width * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].original.Height * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].shift.X, workLayerList[сurrentLayerIndex].shift.Y);
                if (!workLayerList[сurrentLayerIndex].selection.IsEmpty)
                {
                    using (Graphics gr = Graphics.FromImage(workLayerList[сurrentLayerIndex].original))
                    {
                        gr.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                        gr.FillRectangle(Brushes.Transparent, workLayerList[сurrentLayerIndex].selection);
                    }
                    int lastIndex = сurrentLayerIndex;
                    AddLayer(workLayerList[сurrentLayerIndex].CropBitmap(to_draw, workLayerList[сurrentLayerIndex].selection));
                    workLayerList[lastIndex].selection = new Rectangle(0, 0, 0, 0);
                }
            }
        }
    }
}
