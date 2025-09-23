using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap imageA, imageB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = (Image)pictureBox1.Image.Clone();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap source = (Bitmap)pictureBox1.Image;
            Bitmap grayScale = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);

                    int grayValue = (int)(pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    Color grayColor = Color.FromArgb(pixelColor.A, grayValue, grayValue, grayValue);

                    grayScale.SetPixel(x, y, grayColor);
                }
            }
            pictureBox2.Image = grayScale;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap source = (Bitmap)pictureBox1.Image;
            Bitmap inverse = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);

                    Color newColor = Color.FromArgb(pixelColor.A, 255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);

                    inverse.SetPixel(x, y, newColor);
                }
            }
            pictureBox2.Image = inverse;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                string filePath = "C:\\Users\\austi\\Downloads\\saved_image.jpg";
                try
                {
                    pictureBox2.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("Image saved successfully to " + filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No image to save.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap source = (Bitmap)pictureBox1.Image;
            Bitmap sepia = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);

                    int tr = (int)(0.393 * pixelColor.R + 0.769 * pixelColor.G + 0.189 * pixelColor.B);
                    int tg = (int)(0.349 * pixelColor.R + 0.686 * pixelColor.G + 0.168 * pixelColor.B);
                    int tb = (int)(0.272 * pixelColor.R + 0.534 * pixelColor.G + 0.131 * pixelColor.B);

                    tr = Math.Min(255, tr);
                    tg = Math.Min(255, tg);
                    tb = Math.Min(255, tb);

                    Color newColor = Color.FromArgb(pixelColor.A, tr, tg, tb);
                    sepia.SetPixel(x, y, newColor);
                }
            }
            pictureBox2.Image = sepia;
        }
        private void MakeHistogram(Bitmap bmp, PictureBox pictureBox)
        {
            int[] histogram = new int[256];
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int gray = (int)(0.299 * c.R + 0.587 * c.G + 0.114 * c.B);
                    histogram[gray]++;
                }
            }

            int max = histogram.Max();
            Bitmap histImage = new Bitmap(256, 100);
            using (Graphics g = Graphics.FromImage(histImage))
            {
                g.Clear(Color.White);
                for (int i = 0; i < 256; i++)
                {
                    int barHeight = (int)(histogram[i] * 100.0 / max);
                    g.DrawLine(Pens.Black, i, 100, i, 100 - barHeight);
                }
            }
            pictureBox.Image = histImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            MakeHistogram(bmp, pictureBox4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "";
            openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog2.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog2.FileName))
            {
                Image img = Image.FromFile(openFileDialog2.FileName);
                pictureBox2.Image = img;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            imageB = (Bitmap)pictureBox1.Image;
            imageA = (Bitmap)pictureBox2.Image;
            Color myGreen = Color.FromArgb(0, 255, 0);
            int greyGreen = (int)(myGreen.R + myGreen.G + myGreen.B) / 3;
            int threshold = 3;

            for (int x = 0; x < imageA.Width; x++)
            {
                for (int y = 0; y < imageA.Height; y++)
                {
                    Color pixelColor = imageA.GetPixel(x, y);
                    int greyPixel = (int)(pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    if (Math.Abs(greyPixel - greyGreen) < threshold)
                    {
                        Color bgColor = imageB.GetPixel(x, y);
                        imageA.SetPixel(x, y, bgColor);
                    }
                }
            }
            pictureBox4.Image = imageA;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog2.FileName))
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
