
namespace Project_work
{
    partial class ColorBalancing
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
            this.RedLeft = new System.Windows.Forms.TrackBar();
            this.GreenLeft = new System.Windows.Forms.TrackBar();
            this.BlueLeft = new System.Windows.Forms.TrackBar();
            this.preview = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.Brightness = new System.Windows.Forms.Label();
            this.Saturation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BlueRight = new System.Windows.Forms.TrackBar();
            this.GreenRight = new System.Windows.Forms.TrackBar();
            this.RedRight = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.RedLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedRight)).BeginInit();
            this.SuspendLayout();
            // 
            // RedLeft
            // 
            this.RedLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RedLeft.Location = new System.Drawing.Point(30, 51);
            this.RedLeft.Maximum = 255;
            this.RedLeft.Name = "RedLeft";
            this.RedLeft.Size = new System.Drawing.Size(204, 56);
            this.RedLeft.TabIndex = 9;
            this.RedLeft.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedLeft.Scroll += new System.EventHandler(this.ScrollScales);
            // 
            // GreenLeft
            // 
            this.GreenLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GreenLeft.Location = new System.Drawing.Point(30, 126);
            this.GreenLeft.Maximum = 255;
            this.GreenLeft.Name = "GreenLeft";
            this.GreenLeft.Size = new System.Drawing.Size(204, 56);
            this.GreenLeft.TabIndex = 10;
            this.GreenLeft.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenLeft.Scroll += new System.EventHandler(this.ScrollScales);
            // 
            // BlueLeft
            // 
            this.BlueLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BlueLeft.Location = new System.Drawing.Point(30, 201);
            this.BlueLeft.Maximum = 255;
            this.BlueLeft.Name = "BlueLeft";
            this.BlueLeft.Size = new System.Drawing.Size(204, 56);
            this.BlueLeft.TabIndex = 11;
            this.BlueLeft.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueLeft.Scroll += new System.EventHandler(this.ScrollScales);
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.Color.Gray;
            this.preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview.Location = new System.Drawing.Point(30, 263);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(250, 184);
            this.preview.TabIndex = 12;
            this.preview.TabStop = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(310, 263);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(151, 60);
            this.reset.TabIndex = 16;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.ClickReset);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Apply.ForeColor = System.Drawing.Color.White;
            this.Apply.Location = new System.Drawing.Point(310, 387);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(151, 60);
            this.Apply.TabIndex = 15;
            this.Apply.Text = "Применить";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.ClickApply);
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brightness.ForeColor = System.Drawing.Color.White;
            this.Brightness.Location = new System.Drawing.Point(26, 93);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(55, 20);
            this.Brightness.TabIndex = 18;
            this.Brightness.Text = "Green";
            // 
            // Saturation
            // 
            this.Saturation.AutoSize = true;
            this.Saturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saturation.ForeColor = System.Drawing.Color.White;
            this.Saturation.Location = new System.Drawing.Point(26, 19);
            this.Saturation.Name = "Saturation";
            this.Saturation.Size = new System.Drawing.Size(39, 20);
            this.Saturation.TabIndex = 17;
            this.Saturation.Text = "Red";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Blue";
            // 
            // BlueRight
            // 
            this.BlueRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BlueRight.Location = new System.Drawing.Point(257, 201);
            this.BlueRight.Maximum = 255;
            this.BlueRight.Name = "BlueRight";
            this.BlueRight.Size = new System.Drawing.Size(204, 56);
            this.BlueRight.TabIndex = 20;
            this.BlueRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueRight.Value = 255;
            this.BlueRight.Scroll += new System.EventHandler(this.ScrollScales);
            // 
            // GreenRight
            // 
            this.GreenRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GreenRight.Location = new System.Drawing.Point(257, 126);
            this.GreenRight.Maximum = 255;
            this.GreenRight.Name = "GreenRight";
            this.GreenRight.Size = new System.Drawing.Size(204, 56);
            this.GreenRight.TabIndex = 21;
            this.GreenRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenRight.Value = 255;
            this.GreenRight.Scroll += new System.EventHandler(this.ScrollScales);
            // 
            // RedRight
            // 
            this.RedRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RedRight.Location = new System.Drawing.Point(257, 51);
            this.RedRight.Maximum = 255;
            this.RedRight.Name = "RedRight";
            this.RedRight.Size = new System.Drawing.Size(204, 56);
            this.RedRight.TabIndex = 22;
            this.RedRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedRight.Value = 255;
            this.RedRight.Scroll += new System.EventHandler(this.ScrollScales);
            // 
            // ColorBalancing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(494, 474);
            this.Controls.Add(this.RedRight);
            this.Controls.Add(this.GreenRight);
            this.Controls.Add(this.BlueRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.Saturation);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.BlueLeft);
            this.Controls.Add(this.GreenLeft);
            this.Controls.Add(this.RedLeft);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorBalancing";
            this.Text = "Color_Balancing";
            ((System.ComponentModel.ISupportInitialize)(this.RedLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RedLeft;
        private System.Windows.Forms.TrackBar GreenLeft;
        private System.Windows.Forms.TrackBar BlueLeft;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label Brightness;
        private System.Windows.Forms.Label Saturation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar BlueRight;
        private System.Windows.Forms.TrackBar GreenRight;
        private System.Windows.Forms.TrackBar RedRight;
    }
}