using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_work
{
    partial class MainForm
    {
        private Rectangle ConvertSelectionToAbsoluteCoordinates()
        {
            Rectangle absoluteCoordinates = new Rectangle();
            absoluteCoordinates.X += (workLayerList[сurrentLayerIndex].selection.X - workLayerList[сurrentLayerIndex].shift.X) * 100 / workLayerList[сurrentLayerIndex].scale;
            absoluteCoordinates.Y += (workLayerList[сurrentLayerIndex].selection.Y - workLayerList[сurrentLayerIndex].shift.Y) * 100 / workLayerList[сurrentLayerIndex].scale;
            absoluteCoordinates.Width += workLayerList[сurrentLayerIndex].selection.Width * 100 / workLayerList[сurrentLayerIndex].scale;
            absoluteCoordinates.Height += workLayerList[сurrentLayerIndex].selection.Height * 100 / workLayerList[сurrentLayerIndex].scale;
            return absoluteCoordinates;
        }

        private void CopyLayerToClipboard() {
            if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select & workLayerList[сurrentLayerIndex].currentState == (int)States.WaitToAccept)
            {
                Bitmap bitmapToClipboard = workLayerList[сurrentLayerIndex].ResizeBitmap(workLayerList[сurrentLayerIndex].original, workSpace.Width, workSpace.Height,
                                                               workLayerList[сurrentLayerIndex].original.Width * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].original.Height * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].shift.X, workLayerList[сurrentLayerIndex].shift.Y);
                if (!workLayerList[сurrentLayerIndex].selection.IsEmpty)
                {
                    Clipboard.Clear();
                    Clipboard.SetImage(workLayerList[сurrentLayerIndex].CropBitmap(bitmapToClipboard, workLayerList[сurrentLayerIndex].selection));
                    workLayerList[сurrentLayerIndex].selection = new Rectangle(0, 0, 0, 0);
                }
            }
            else
            {
                Clipboard.Clear();
                Clipboard.SetImage(workLayerList[сurrentLayerIndex].original);
            }

            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref layerPanel, ref сurrentLayerIndex);
            workSpace.Refresh();
        }

        private void CutLayerToClipboard() {
            if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select & workLayerList[сurrentLayerIndex].currentState == (int)States.WaitToAccept)
            {
                Bitmap bitmapToClipboard = workLayerList[сurrentLayerIndex].ResizeBitmap(workLayerList[сurrentLayerIndex].original, workSpace.Width, workSpace.Height,
                                                               workLayerList[сurrentLayerIndex].original.Width * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].original.Height * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].shift.X, workLayerList[сurrentLayerIndex].shift.Y);
                if (!workLayerList[сurrentLayerIndex].selection.IsEmpty)
                {
                    Rectangle cuttingPiece = ConvertSelectionToAbsoluteCoordinates();
                    using (Graphics gr = Graphics.FromImage(workLayerList[сurrentLayerIndex].original))
                    {
                        gr.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                        gr.FillRectangle(Brushes.Transparent, cuttingPiece);
                    }
                    Clipboard.Clear();
                    Clipboard.SetImage(workLayerList[сurrentLayerIndex].CropBitmap(bitmapToClipboard, workLayerList[сurrentLayerIndex].selection));
                    workLayerList[сurrentLayerIndex].selection = new Rectangle(0, 0, 0, 0);
                }
            }

            else
            {
                Rectangle fullSizeRect = new Rectangle(0, 0, workLayerList[сurrentLayerIndex].original.Width, workLayerList[сurrentLayerIndex].original.Height);
                Clipboard.Clear();
                Clipboard.SetImage(workLayerList[сurrentLayerIndex].original);
                using (Graphics gr = Graphics.FromImage(workLayerList[сurrentLayerIndex].original))
                {
                    gr.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                    gr.FillRectangle(Brushes.Transparent, fullSizeRect);
                }
            }

            workSpace.Image = Layer.DrawLayersList(ref workLayerList, ref workSpace);
            LayerVisualiser.UpdateLayersPreviews(ref workLayerList, ref layerPanel, ref сurrentLayerIndex);
            workSpace.Refresh();
        }
        private void CopyToNewLayerContextClick(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
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
            if (!CheckCorrectIndexAndBitmap()) return;
            if (workLayerList[сurrentLayerIndex].activeInstrument == (int)Instruments.Select & workLayerList[сurrentLayerIndex].currentState == (int)States.WaitToAccept)
            {
                Bitmap bitmapToCrop = workLayerList[сurrentLayerIndex].ResizeBitmap(workLayerList[сurrentLayerIndex].original, workSpace.Width, workSpace.Height,
                                                               workLayerList[сurrentLayerIndex].original.Width * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].original.Height * workLayerList[сurrentLayerIndex].scale / 100,
                                                               workLayerList[сurrentLayerIndex].shift.X, workLayerList[сurrentLayerIndex].shift.Y);
                if (!workLayerList[сurrentLayerIndex].selection.IsEmpty)
                {
                    Rectangle cuttingPiece = ConvertSelectionToAbsoluteCoordinates();
                    using (Graphics gr = Graphics.FromImage(workLayerList[сurrentLayerIndex].original))
                    {
                        gr.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                        gr.FillRectangle(Brushes.Transparent, cuttingPiece);
                    }
                    int lastIndex = сurrentLayerIndex;
                    AddLayer(workLayerList[сurrentLayerIndex].CropBitmap(bitmapToCrop, workLayerList[сurrentLayerIndex].selection));
                    workLayerList[lastIndex].selection = new Rectangle(0, 0, 0, 0);
                }
            }
        }


        private void ClickCopyToolStripMenuItem(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            CopyLayerToClipboard();
        }

        private void ClickCutToolStripMenuItem(object sender, EventArgs e)
        {
            if (!CheckCorrectIndexAndBitmap()) return;
            CutLayerToClipboard();
        }
    }
}
