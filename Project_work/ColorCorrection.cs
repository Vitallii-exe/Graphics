using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;

namespace Project_work
{
    public partial class ColorCorrection : Form
    {
        Bitmap original_to_correct;
        //Bitmap final_corrected;

        public ColorCorrection(ref Bitmap original)
        {
            InitializeComponent();
            original_to_correct = original;
            preview.BackgroundImage = original_to_correct;
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Apply_Click(object sender, EventArgs e)
        {
            SaturationCorrection sat_filter = new SaturationCorrection((float)SatScale.Value / 100);
            sat_filter.ApplyInPlace(original_to_correct);
            BrightnessCorrection br_filter = new BrightnessCorrection(BrScale.Value);
            br_filter.ApplyInPlace(original_to_correct);
            Close();
        }

        private void _Scroll(object sender, EventArgs e)
        {
            Bitmap now_corr = new Bitmap(original_to_correct);
            SaturationCorrection sat_filter = new SaturationCorrection((float)SatScale.Value / 100);
            sat_filter.ApplyInPlace(now_corr);
            BrightnessCorrection br_filter = new BrightnessCorrection(BrScale.Value);
            br_filter.ApplyInPlace(now_corr);
            preview.BackgroundImage = now_corr;
            preview.Refresh();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            SatScale.Value = 0;
            BrScale.Value = 0;
            preview.BackgroundImage = original_to_correct;
            preview.Refresh();
        }
    }
}
