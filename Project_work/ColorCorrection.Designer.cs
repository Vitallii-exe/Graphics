
namespace Project_work
{
    partial class ColorCorrection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Saturation = new System.Windows.Forms.Label();
            this.SatScale = new System.Windows.Forms.TrackBar();
            this.BrScale = new System.Windows.Forms.TrackBar();
            this.Brightness = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.Preview_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SatScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // Saturation
            // 
            this.Saturation.AutoSize = true;
            this.Saturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saturation.ForeColor = System.Drawing.Color.White;
            this.Saturation.Location = new System.Drawing.Point(39, 31);
            this.Saturation.Name = "Saturation";
            this.Saturation.Size = new System.Drawing.Size(136, 20);
            this.Saturation.TabIndex = 0;
            this.Saturation.Text = "Насыщенность";
            // 
            // SatScale
            // 
            this.SatScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SatScale.Location = new System.Drawing.Point(43, 59);
            this.SatScale.Maximum = 100;
            this.SatScale.Minimum = -100;
            this.SatScale.Name = "SatScale";
            this.SatScale.Size = new System.Drawing.Size(361, 56);
            this.SatScale.TabIndex = 9;
            this.SatScale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SatScale.Scroll += new System.EventHandler(this.Scroll);
            // 
            // BrScale
            // 
            this.BrScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BrScale.Location = new System.Drawing.Point(43, 155);
            this.BrScale.Maximum = 255;
            this.BrScale.Minimum = -255;
            this.BrScale.Name = "BrScale";
            this.BrScale.Size = new System.Drawing.Size(361, 56);
            this.BrScale.TabIndex = 11;
            this.BrScale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrScale.Scroll += new System.EventHandler(this.Scroll);
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brightness.ForeColor = System.Drawing.Color.White;
            this.Brightness.Location = new System.Drawing.Point(39, 126);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(80, 20);
            this.Brightness.TabIndex = 10;
            this.Brightness.Text = "Яркость";
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Apply.ForeColor = System.Drawing.Color.White;
            this.Apply.Location = new System.Drawing.Point(331, 352);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(151, 60);
            this.Apply.TabIndex = 12;
            this.Apply.Text = "Применить";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.Color.Gray;
            this.preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview.Location = new System.Drawing.Point(43, 245);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(260, 167);
            this.preview.TabIndex = 13;
            this.preview.TabStop = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(331, 245);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(151, 60);
            this.reset.TabIndex = 14;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Preview_label
            // 
            this.Preview_label.AutoSize = true;
            this.Preview_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Preview_label.ForeColor = System.Drawing.Color.White;
            this.Preview_label.Location = new System.Drawing.Point(39, 207);
            this.Preview_label.Name = "Preview_label";
            this.Preview_label.Size = new System.Drawing.Size(140, 20);
            this.Preview_label.TabIndex = 15;
            this.Preview_label.Text = "Предпросмотр:";
            // 
            // ColorCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(524, 449);
            this.Controls.Add(this.Preview_label);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.BrScale);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.SatScale);
            this.Controls.Add(this.Saturation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorCorrection";
            this.Text = "ColorCorrection";
            ((System.ComponentModel.ISupportInitialize)(this.SatScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saturation;
        private System.Windows.Forms.TrackBar SatScale;
        private System.Windows.Forms.TrackBar BrScale;
        private System.Windows.Forms.Label Brightness;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label Preview_label;
    }
}