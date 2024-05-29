namespace Bitmap_Analyzer
{
    partial class FormMain
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxGrayscaled = new System.Windows.Forms.PictureBox();
            this.buttonLoadBitmap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxGrayscaledHistogram = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxRedHistogram = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxGreenHistogram = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxBlueHistogram = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxRedImage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxGreenImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxBlueImage = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxRGBHistogram = new System.Windows.Forms.PictureBox();
            this.trackBarBeta = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.labelBeta = new System.Windows.Forms.Label();
            this.labelGamma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscaled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscaledHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRGBHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.Color.White;
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(15, 77);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            this.pictureBoxOriginal.Click += new System.EventHandler(this.pictureBoxOriginal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Image:";
            // 
            // pictureBoxGrayscaled
            // 
            this.pictureBoxGrayscaled.BackColor = System.Drawing.Color.White;
            this.pictureBoxGrayscaled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGrayscaled.Location = new System.Drawing.Point(421, 77);
            this.pictureBoxGrayscaled.Name = "pictureBoxGrayscaled";
            this.pictureBoxGrayscaled.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxGrayscaled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGrayscaled.TabIndex = 2;
            this.pictureBoxGrayscaled.TabStop = false;
            // 
            // buttonLoadBitmap
            // 
            this.buttonLoadBitmap.Location = new System.Drawing.Point(15, 10);
            this.buttonLoadBitmap.Name = "buttonLoadBitmap";
            this.buttonLoadBitmap.Size = new System.Drawing.Size(215, 31);
            this.buttonLoadBitmap.TabIndex = 3;
            this.buttonLoadBitmap.Text = "Load Bitmap";
            this.buttonLoadBitmap.UseVisualStyleBackColor = true;
            this.buttonLoadBitmap.Click += new System.EventHandler(this.buttonLoadBitmap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grayscaled Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grayscaled Histogram:";
            // 
            // pictureBoxGrayscaledHistogram
            // 
            this.pictureBoxGrayscaledHistogram.BackColor = System.Drawing.Color.White;
            this.pictureBoxGrayscaledHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGrayscaledHistogram.Location = new System.Drawing.Point(836, 77);
            this.pictureBoxGrayscaledHistogram.Name = "pictureBoxGrayscaledHistogram";
            this.pictureBoxGrayscaledHistogram.Size = new System.Drawing.Size(290, 81);
            this.pictureBoxGrayscaledHistogram.TabIndex = 7;
            this.pictureBoxGrayscaledHistogram.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(833, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Red Histogram:";
            // 
            // pictureBoxRedHistogram
            // 
            this.pictureBoxRedHistogram.BackColor = System.Drawing.Color.White;
            this.pictureBoxRedHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRedHistogram.Location = new System.Drawing.Point(836, 186);
            this.pictureBoxRedHistogram.Name = "pictureBoxRedHistogram";
            this.pictureBoxRedHistogram.Size = new System.Drawing.Size(290, 81);
            this.pictureBoxRedHistogram.TabIndex = 9;
            this.pictureBoxRedHistogram.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Green Histogram:";
            // 
            // pictureBoxGreenHistogram
            // 
            this.pictureBoxGreenHistogram.BackColor = System.Drawing.Color.White;
            this.pictureBoxGreenHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGreenHistogram.Location = new System.Drawing.Point(836, 302);
            this.pictureBoxGreenHistogram.Name = "pictureBoxGreenHistogram";
            this.pictureBoxGreenHistogram.Size = new System.Drawing.Size(290, 81);
            this.pictureBoxGreenHistogram.TabIndex = 11;
            this.pictureBoxGreenHistogram.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Blue Histogram:";
            // 
            // pictureBoxBlueHistogram
            // 
            this.pictureBoxBlueHistogram.BackColor = System.Drawing.Color.White;
            this.pictureBoxBlueHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlueHistogram.Location = new System.Drawing.Point(836, 410);
            this.pictureBoxBlueHistogram.Name = "pictureBoxBlueHistogram";
            this.pictureBoxBlueHistogram.Size = new System.Drawing.Size(290, 81);
            this.pictureBoxBlueHistogram.TabIndex = 13;
            this.pictureBoxBlueHistogram.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Red:";
            // 
            // pictureBoxRedImage
            // 
            this.pictureBoxRedImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxRedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRedImage.Location = new System.Drawing.Point(13, 469);
            this.pictureBoxRedImage.Name = "pictureBoxRedImage";
            this.pictureBoxRedImage.Size = new System.Drawing.Size(252, 189);
            this.pictureBoxRedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRedImage.TabIndex = 15;
            this.pictureBoxRedImage.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Green:";
            // 
            // pictureBoxGreenImage
            // 
            this.pictureBoxGreenImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxGreenImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGreenImage.Location = new System.Drawing.Point(289, 469);
            this.pictureBoxGreenImage.Name = "pictureBoxGreenImage";
            this.pictureBoxGreenImage.Size = new System.Drawing.Size(252, 189);
            this.pictureBoxGreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGreenImage.TabIndex = 17;
            this.pictureBoxGreenImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(564, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Blue:";
            // 
            // pictureBoxBlueImage
            // 
            this.pictureBoxBlueImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxBlueImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlueImage.Location = new System.Drawing.Point(567, 469);
            this.pictureBoxBlueImage.Name = "pictureBoxBlueImage";
            this.pictureBoxBlueImage.Size = new System.Drawing.Size(252, 189);
            this.pictureBoxBlueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBlueImage.TabIndex = 19;
            this.pictureBoxBlueImage.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(833, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "RGB Histogram:";
            // 
            // pictureBoxRGBHistogram
            // 
            this.pictureBoxRGBHistogram.BackColor = System.Drawing.Color.White;
            this.pictureBoxRGBHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRGBHistogram.Location = new System.Drawing.Point(836, 520);
            this.pictureBoxRGBHistogram.Name = "pictureBoxRGBHistogram";
            this.pictureBoxRGBHistogram.Size = new System.Drawing.Size(290, 81);
            this.pictureBoxRGBHistogram.TabIndex = 21;
            this.pictureBoxRGBHistogram.TabStop = false;
            // 
            // trackBarBeta
            // 
            this.trackBarBeta.Enabled = false;
            this.trackBarBeta.Location = new System.Drawing.Point(60, 383);
            this.trackBarBeta.Maximum = 200;
            this.trackBarBeta.Name = "trackBarBeta";
            this.trackBarBeta.Size = new System.Drawing.Size(130, 45);
            this.trackBarBeta.TabIndex = 23;
            this.trackBarBeta.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBeta.Value = 100;
            this.trackBarBeta.Scroll += new System.EventHandler(this.trackBarBeta_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Beta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Gamma:";
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Enabled = false;
            this.trackBarGamma.Location = new System.Drawing.Point(281, 383);
            this.trackBarGamma.Maximum = 200;
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(130, 45);
            this.trackBarGamma.TabIndex = 26;
            this.trackBarGamma.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGamma.Value = 100;
            this.trackBarGamma.Scroll += new System.EventHandler(this.trackBarGamma_Scroll);
            // 
            // labelBeta
            // 
            this.labelBeta.Location = new System.Drawing.Point(60, 410);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(130, 18);
            this.labelBeta.TabIndex = 27;
            this.labelBeta.Text = "0";
            this.labelBeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGamma
            // 
            this.labelGamma.Location = new System.Drawing.Point(278, 410);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(130, 18);
            this.labelGamma.TabIndex = 28;
            this.labelGamma.Text = "1,00";
            this.labelGamma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1143, 672);
            this.Controls.Add(this.labelGamma);
            this.Controls.Add(this.labelBeta);
            this.Controls.Add(this.trackBarGamma);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trackBarBeta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBoxRGBHistogram);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxBlueImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBoxGreenImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxRedImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBoxBlueHistogram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxGreenHistogram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxRedHistogram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxGrayscaledHistogram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLoadBitmap);
            this.Controls.Add(this.pictureBoxGrayscaled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscaled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscaledHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRGBHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxGrayscaled;
        private System.Windows.Forms.Button buttonLoadBitmap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxGrayscaledHistogram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxRedHistogram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxGreenHistogram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxBlueHistogram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxRedImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxGreenImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxBlueImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxRGBHistogram;
        private System.Windows.Forms.TrackBar trackBarBeta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.Label labelGamma;
    }
}

