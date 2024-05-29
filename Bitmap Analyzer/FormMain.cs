using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Bitmap_Analyzer
{
    public partial class FormMain : Form
    {
        private Bitmap bitmapOriginal;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoadBitmap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Bitmap";
            ofd.Filter = "Image Files (*.jpg;*.png;*.bmp;*.jpeg;*.gif)|*.jpg;*.png;*.bmp;*.jpeg;*.gif";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bitmapOriginal = (Bitmap)Image.FromFile(ofd.FileName);

                if (Image.IsCanonicalPixelFormat(bitmapOriginal.PixelFormat))
                {
                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                    bitmapOriginal.Save(memoryStream, ImageFormat.Jpeg);

                    bitmapOriginal.Dispose();
                    bitmapOriginal = null;

                    bitmapOriginal = (Bitmap)Image.FromStream(memoryStream);
                }

                buttonLoadBitmap.Enabled = false;

                pictureBoxOriginal.Image = bitmapOriginal;

                Bitmap[] bitmaps = BitmapAlgorithms.ProcessBitmap(bitmapOriginal);
                pictureBoxGrayscaled.Image = bitmaps[0];
                pictureBoxRedImage.Image = bitmaps[1];
                pictureBoxGreenImage.Image = bitmaps[2];
                pictureBoxBlueImage.Image = bitmaps[3];

                Bitmap[] histograms = BitmapAlgorithms.GenerateHistograms(bitmapOriginal, pictureBoxGrayscaledHistogram.Width, pictureBoxGrayscaledHistogram.Height);
                pictureBoxGrayscaledHistogram.Image = histograms[0];
                pictureBoxRedHistogram.Image = histograms[1];
                pictureBoxGreenHistogram.Image = histograms[2];
                pictureBoxBlueHistogram.Image = histograms[3];
                pictureBoxRGBHistogram.Image = histograms[4];

                buttonLoadBitmap.Enabled = true;
                trackBarBeta.Enabled = true;
                trackBarGamma.Enabled = true;

                trackBarBeta.Value = trackBarBeta.Maximum / 2;
                trackBarGamma.Value = trackBarGamma.Maximum / 2;

                labelBeta.Text = "0";
                labelGamma.Text = "1,00";
            }
        }

        private void trackBarBeta_Scroll(object sender, EventArgs e)
        {
            int beta = trackBarBeta.Value -  trackBarBeta.Maximum / 2;
            labelBeta.Text = beta.ToString();

            trackBarGamma.Value = trackBarGamma.Maximum / 2;
            labelGamma.Text = "1,00";

            pictureBoxOriginal.Image = BitmapAlgorithms.BetaCorrected(bitmapOriginal, beta);
        }

        private void trackBarGamma_Scroll(object sender, EventArgs e)
        {
            float gamma = (float)trackBarGamma.Value / trackBarGamma.Maximum * 2.0f;
            labelGamma.Text = gamma.ToString("F2");

            trackBarBeta.Value = trackBarBeta.Maximum / 2;
            labelBeta.Text = "0";

            pictureBoxOriginal.Image = BitmapAlgorithms.GammaCorrected(bitmapOriginal, gamma);
        }

        private void pictureBoxOriginal_Click(object sender, EventArgs e)
        {
            pictureBoxOriginal.Image = bitmapOriginal;

            trackBarBeta.Value = trackBarBeta.Maximum / 2;
            trackBarGamma.Value = trackBarGamma.Maximum / 2;

            labelBeta.Text = "0";
            labelGamma.Text = "1,00";
        }
    }
}
