using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Bitmap_Analyzer
{
    public static class BitmapAlgorithms
    {
        private class Pixel
        {
            public byte r, g, b;

            public static Pixel FromByteArray(byte[] data, int i)
            {
                return new Pixel { b = data[i], g = data[i + 1], r = data[i + 2] };
            }

            public void ToByteArray(byte[] data, int i)
            {
                data[i] = b; data[i + 1] = g; data[i + 2] = r;
            }

            public Pixel Grayscaled()
            {
                Pixel grayPixel = new Pixel();
                grayPixel.r = grayPixel.g = grayPixel.b = (byte)(r * 0.34f + g * 0.56f + b * 0.10f);
                return grayPixel;
            }

            public Pixel RedOnly()
            {
                Pixel redOnly = new Pixel();
                redOnly.r = r;
                return redOnly;
            }

            public Pixel GreenOnly()
            {
                Pixel greenOnly = new Pixel();
                greenOnly.g = g;
                return greenOnly;
            }

            public Pixel BlueOnly()
            {
                Pixel blueOnly = new Pixel();
                blueOnly.b = b;
                return blueOnly;
            }
        }

        public static Bitmap[] ProcessBitmap(Bitmap bitmap)
        {
            BitmapData originalBitmapData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            byte[] originalBitmapBytes = new byte[Math.Abs(originalBitmapData.Stride) * bitmap.Height];
            Marshal.Copy(originalBitmapData.Scan0, originalBitmapBytes, 0, originalBitmapBytes.Length);
            bitmap.UnlockBits(originalBitmapData);

            Bitmap bitmapGrayscaled = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb);
            Bitmap bitmapRedOnly = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb);
            Bitmap bitmapGreenOnly = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb);
            Bitmap bitmapBlueOnly = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(Point.Empty, bitmap.Size);
            PixelFormat pixelFormat = PixelFormat.Format24bppRgb;

            BitmapData bitmapGrayscaledData = bitmapGrayscaled.LockBits(rect, ImageLockMode.ReadWrite, pixelFormat);
            BitmapData bitmapRedOnlyData = bitmapRedOnly.LockBits(rect, ImageLockMode.ReadWrite, pixelFormat);
            BitmapData bitmapGreenOnlyData = bitmapGreenOnly.LockBits(rect, ImageLockMode.ReadWrite, pixelFormat);
            BitmapData bitmapBlueOnlyData = bitmapBlueOnly.LockBits(rect, ImageLockMode.ReadWrite, pixelFormat);

            int commonSize = Math.Abs(bitmapGrayscaledData.Stride) * bitmapGrayscaledData.Height;

            byte[] bitmapGrayscaledBytes = new byte[commonSize];
            byte[] bitmapRedOnlyBytes = new byte[commonSize];
            byte[] bitmapGreenOnlyBytes = new byte[commonSize];
            byte[] bitmapBlueOnlyBytes = new byte[commonSize];

            Marshal.Copy(bitmapGrayscaledData.Scan0, bitmapGrayscaledBytes, 0, commonSize);
            Marshal.Copy(bitmapRedOnlyData.Scan0, bitmapRedOnlyBytes, 0, commonSize);
            Marshal.Copy(bitmapGreenOnlyData.Scan0, bitmapGreenOnlyBytes, 0, commonSize);
            Marshal.Copy(bitmapBlueOnlyData.Scan0, bitmapBlueOnlyBytes, 0, commonSize);

            int step = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;

            for (int i = 0; i < originalBitmapBytes.Length - (originalBitmapBytes.Length % step); i += step)
            {
                Pixel p = Pixel.FromByteArray(originalBitmapBytes, i);
                p.Grayscaled().ToByteArray(bitmapGrayscaledBytes, i);
                p.RedOnly().ToByteArray(bitmapRedOnlyBytes, i);
                p.GreenOnly().ToByteArray(bitmapGreenOnlyBytes, i);
                p.BlueOnly().ToByteArray(bitmapBlueOnlyBytes, i);
            }

            Marshal.Copy(bitmapGrayscaledBytes, 0, bitmapGrayscaledData.Scan0, commonSize);
            Marshal.Copy(bitmapRedOnlyBytes, 0, bitmapRedOnlyData.Scan0, commonSize);
            Marshal.Copy(bitmapGreenOnlyBytes, 0, bitmapGreenOnlyData.Scan0, commonSize);
            Marshal.Copy(bitmapBlueOnlyBytes, 0, bitmapBlueOnlyData.Scan0, commonSize);

            bitmapGrayscaled.UnlockBits(bitmapGrayscaledData);
            bitmapRedOnly.UnlockBits(bitmapRedOnlyData);
            bitmapGreenOnly.UnlockBits(bitmapGreenOnlyData);
            bitmapBlueOnly.UnlockBits(bitmapBlueOnlyData);

            return new Bitmap[] { bitmapGrayscaled, bitmapRedOnly, bitmapGreenOnly, bitmapBlueOnly };
        }

        private static void DrawHistogramGraph(Graphics g, int[] data, int width, int height, Color color)
        {
            int max = 0;
            for (int i = 0; i < data.Length; i++) max = max >= data[i] ? max : data[i];

            float w = width / 255.0f;
            float h = (float)max / height;
            if (h > 1.0f) h = 1.0f / h;

            float lastX = -1.0f, lastY = -1.0f;

            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(color);

            for (int i = 0; i <= 255; i++)
            {
                float x = i * w, y = height - data[i] * h;

                g.FillEllipse(brush, x - 0.5f, y - 0.5f, 1.0f, 1.0f);

                if (lastX != -1.0f) g.DrawLine(pen, lastX, lastY, x, y);

                lastX = x; lastY = y;
            }
        }

        private static Bitmap GenerateHistogramGraph(int[] data, int width, int height , Color color)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bitmap);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.Clear(Color.White);

            DrawHistogramGraph(g, data, width, height, color);

            return bitmap;
        }

        private static Bitmap GenerateHistogramGraph(int[][] data, int width, int height, Color[] colors)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bitmap);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.Clear(Color.White);

            for (int i = 0; i < data.Length; i++)
            {
                DrawHistogramGraph(g, data[i], width, height, colors[i]);
            }

            return bitmap;
        }

        public static Bitmap[] GenerateHistograms(Bitmap bitmap, int width, int height)
        {
            int[] grays = new int[256], reds = new int[256], greens = new int[256], blues = new int[256];

            BitmapData bitmapData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            byte[] data = new byte[Math.Abs(bitmapData.Stride) * bitmapData.Height];
            Marshal.Copy(bitmapData.Scan0, data, 0, data.Length);
            bitmap.UnlockBits(bitmapData);

            int step = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;

            for (int i = 0; i < data.Length - (data.Length % step); i+=step)
            {
                Pixel p = Pixel.FromByteArray(data, i);

                grays[(byte)(p.r * 0.56f + p.g * 0.34f + p.b * 0.10f)]++; reds[p.r]++; greens[p.g]++; blues[p.b]++;
            }

            Bitmap bitmapGrayscaled = GenerateHistogramGraph(grays, width, height, Color.Black);
            Bitmap bitmapReds = GenerateHistogramGraph(reds, width, height, Color.Red);
            Bitmap bitmapGreens = GenerateHistogramGraph(greens, width, height, Color.Green);
            Bitmap bitmapBlues = GenerateHistogramGraph(blues, width, height, Color.Blue);

            Bitmap bitmapRGB = GenerateHistogramGraph(new int[][] { reds, greens, blues }, width, height, 
                new Color[] { Color.Red, Color.Green, Color.Blue });

            return new Bitmap[] { bitmapGrayscaled, bitmapReds, bitmapGreens, bitmapBlues, bitmapRGB };
        }

        public static Bitmap BetaCorrected(Bitmap bitmapOriginal, int beta)
        {
            BitmapData bitmapOriginalData = bitmapOriginal.LockBits(new Rectangle(Point.Empty, bitmapOriginal.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            byte[] bitmapOriginalBytes = new byte[Math.Abs(bitmapOriginalData.Stride) * bitmapOriginalData.Height];
            Marshal.Copy(bitmapOriginalData.Scan0, bitmapOriginalBytes, 0, bitmapOriginalBytes.Length);
            bitmapOriginal.UnlockBits(bitmapOriginalData);

            Bitmap betaCorrectedBitmap = new Bitmap(bitmapOriginal.Width, bitmapOriginal.Height, PixelFormat.Format24bppRgb);
            BitmapData betaCorrectedData = betaCorrectedBitmap.LockBits(new Rectangle(Point.Empty, betaCorrectedBitmap.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] betaCorrectedBytes = new byte[Math.Abs(betaCorrectedData.Stride) * betaCorrectedData.Height];

            Marshal.Copy(betaCorrectedData.Scan0, betaCorrectedBytes, 0, betaCorrectedBytes.Length);

            for (int i = 0; i < bitmapOriginalBytes.Length; i++)
            {
                int val = bitmapOriginalBytes[i];
                val += beta;
                if (val < 0) val = 0;
                if (val > 255) val = 255;
                betaCorrectedBytes[i] = (byte)val;
            }

            Marshal.Copy(betaCorrectedBytes, 0, betaCorrectedData.Scan0, betaCorrectedBytes.Length);

            betaCorrectedBitmap.UnlockBits(betaCorrectedData);

            return betaCorrectedBitmap;
        }

        public static Bitmap GammaCorrected(Bitmap bitmapOriginal, float gamma)
        {
            BitmapData bitmapOriginalData = bitmapOriginal.LockBits(new Rectangle(Point.Empty, bitmapOriginal.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            byte[] bitmapOriginalBytes = new byte[Math.Abs(bitmapOriginalData.Stride) * bitmapOriginalData.Height];
            Marshal.Copy(bitmapOriginalData.Scan0, bitmapOriginalBytes, 0, bitmapOriginalBytes.Length);
            bitmapOriginal.UnlockBits(bitmapOriginalData);

            Bitmap gammaCorrectedBitmap = new Bitmap(bitmapOriginal.Width, bitmapOriginal.Height, PixelFormat.Format24bppRgb);
            BitmapData gammaCorrectedData = gammaCorrectedBitmap.LockBits(new Rectangle(Point.Empty, gammaCorrectedBitmap.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] gammaCorrectedBytes = new byte[Math.Abs(gammaCorrectedData.Stride) * gammaCorrectedData.Height];

            Marshal.Copy(gammaCorrectedData.Scan0, gammaCorrectedBytes, 0, gammaCorrectedBytes.Length);

            for (int i = 0; i < bitmapOriginalBytes.Length; i++)
            {
                float val = bitmapOriginalBytes[i] / 255.0f;
                val = (float)Math.Pow(val, gamma);
                gammaCorrectedBytes[i] = (byte)(val * 255.0f);
            }

            Marshal.Copy(gammaCorrectedBytes, 0, gammaCorrectedData.Scan0, gammaCorrectedBytes.Length);

            gammaCorrectedBitmap.UnlockBits(gammaCorrectedData);

            return gammaCorrectedBitmap;
        }
    }
}
