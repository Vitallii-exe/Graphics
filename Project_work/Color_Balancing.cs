using System;
using System.Drawing;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.Filters;

namespace Project_work
{
    public partial class ColorBalancing : Form
    {
        Bitmap originalToCorrect;
        public ColorBalancing(ref Bitmap original)
        {
            InitializeComponent();
            originalToCorrect = original;
            preview.BackgroundImage = originalToCorrect;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ScrollScales(object sender, EventArgs e)
        {
            Bitmap nowCorrection = new Bitmap(originalToCorrect);

            LevelsLinear colorBalancingFilter = new LevelsLinear();
            colorBalancingFilter.InRed = new IntRange(RedLeft.Value, RedRight.Value);
            colorBalancingFilter.InGreen = new IntRange(GreenLeft.Value, GreenRight.Value);
            colorBalancingFilter.InBlue = new IntRange(BlueLeft.Value, BlueRight.Value);
            colorBalancingFilter.ApplyInPlace(nowCorrection);
            preview.BackgroundImage = nowCorrection;
            preview.Refresh();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void ClickReset(object sender, EventArgs e)
        {
            RedLeft.Value = 0;
            GreenLeft.Value = 0;
            BlueLeft.Value = 0;

            RedRight.Value = 255;
            GreenRight.Value = 255;
            BlueRight.Value = 255;
            preview.BackgroundImage = originalToCorrect;
            preview.Refresh();
        }

        private void ClickApply(object sender, EventArgs e)
        {
            LevelsLinear colorBalancingFilter = new LevelsLinear();
            colorBalancingFilter.InRed = new IntRange(RedLeft.Value, RedRight.Value);
            colorBalancingFilter.InGreen = new IntRange(GreenLeft.Value, GreenRight.Value);
            colorBalancingFilter.InBlue = new IntRange(BlueLeft.Value, BlueRight.Value);
            colorBalancingFilter.ApplyInPlace(originalToCorrect);
            Close();
        }
    }
}
