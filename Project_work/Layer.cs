using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

public class Layer
{
    public Bitmap original = new Bitmap(675, 504);
    public Button preview = new Button();
    public CheckBox isVisibleCheckbox = new CheckBox();
    public Label labelCaption = new Label();
    public bool isVisible = true;

    public int activeInstrument = 0;
    public int currentState = -1;

    public Pen layerPen = new Pen(Color.FromArgb(255, Color.Black), 10.0f) { StartCap = System.Drawing.Drawing2D.LineCap.Round, EndCap = System.Drawing.Drawing2D.LineCap.Round };
    public Pen eraserPen = new Pen(Brushes.Transparent, 10.0f) { StartCap = System.Drawing.Drawing2D.LineCap.Round, EndCap = System.Drawing.Drawing2D.LineCap.Round };
    public Pen selectionPen = new Pen(Brushes.Black, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash};

    public Point startPosition = new Point(0, 0);
    public Point startPositionSelection = new Point(0, 0);
    public Point shift = new Point(0, 0);
    public Point shiftTmp = new Point(0, 0);
    public Point lastPosition = new Point(0, 0);

    public Rectangle selection = new Rectangle(0, 0, 0, 0);
    public int scale = 100;

    public Bitmap ResizeBitmap(Bitmap sourceBitmap, int picBoxWidth, int PicBoxHeight, int width, int height, int shiftX = 0, int shiftY = 0)
    {
        // Изменяет размер Bitmapa, а также сдвигает его на заданное число пикселей
        Bitmap result = new Bitmap(picBoxWidth, PicBoxHeight);
        using (Graphics g = Graphics.FromImage(result))
        {
            g.DrawImage(sourceBitmap, shiftX, shiftY, width, height);
        }
        return result;
    }

    public Bitmap CropBitmap(Bitmap sourceBitmap, Rectangle cropArea)
    {
        if (cropArea.Width > 0 & cropArea.Height > 0)
        {
            // Обрезает Bitmap по заданному Rectangle
            Bitmap bmpImage = new Bitmap(sourceBitmap);
            Bitmap cropped_bitmap = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return cropped_bitmap;
        }
        else return sourceBitmap;
    }

    public Rectangle GetSelRectangle(Point orig, Point location)
    {
        // Создает Rectangle по двум точкам - orig и location
        int deltaX = location.X - orig.X, deltaY = location.Y - orig.Y;
        Size sizeArea = new Size(Math.Abs(deltaX), Math.Abs(deltaY));
        Rectangle selectedSquare = new Rectangle();

        if (deltaX >= 0 & deltaY >= 0)
        {
            selectedSquare = new Rectangle(orig, sizeArea);
            return selectedSquare;
        }
        else if (deltaX < 0 & deltaY > 0)
        {
            selectedSquare = new Rectangle(location.X, orig.Y, sizeArea.Width, sizeArea.Height);
            return selectedSquare;
        }
        else if (deltaX < 0 & deltaY < 0)
        {
            selectedSquare = new Rectangle(location, sizeArea);
            return selectedSquare;
        }
        else if (deltaX > 0 & deltaY < 0)
        {
            selectedSquare = new Rectangle(orig.X, location.Y, sizeArea.Width, sizeArea.Height);
            return selectedSquare;
        }
        else return selectedSquare;
    }

    public static Bitmap BrushDraw(ref Bitmap source, ref Pen brush_pen, ref Point start_point, ref Point finish_point, bool Erase=false) 
    {
        // Рисует brush_pen'ом линию по 2-м точкам
        using (Graphics g = Graphics.FromImage(source))
        {
            if (Erase) g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            g.DrawLine(brush_pen, start_point.X, start_point.Y, finish_point.X, finish_point.Y);
        }
        return source;
    }

    public static Bitmap DrawLayersList(ref List<Layer> workLayerList, ref PictureBox workSpace, bool tmp = false)
    {
        Bitmap result = new Bitmap(workSpace.Width, workSpace.Height);
        using (Graphics g = Graphics.FromImage(result))
        {
            for (int i = 0; i < workLayerList.Count; i++)
            {
                if (workLayerList[i].isVisible)
                {
                    Bitmap to_draw = null;
                    if (!tmp)
                    {
                        to_draw = workLayerList[i].ResizeBitmap(workLayerList[i].original, workSpace.Width, workSpace.Height,
                                                               workLayerList[i].original.Width * workLayerList[i].scale / 100,
                                                               workLayerList[i].original.Height * workLayerList[i].scale / 100,
                                                               workLayerList[i].shift.X, workLayerList[i].shift.Y);
                    }
                    else
                    {
                        to_draw = workLayerList[i].ResizeBitmap(workLayerList[i].original, workSpace.Width, workSpace.Height,
                                                               workLayerList[i].original.Width * workLayerList[i].scale / 100,
                                                               workLayerList[i].original.Height * workLayerList[i].scale / 100,
                                                               workLayerList[i].shiftTmp.X, workLayerList[i].shiftTmp.Y);
                    }

                    g.DrawImage(to_draw, 0, 0, to_draw.Width, to_draw.Height);
                }
            }
        }
        return result;
    }
}