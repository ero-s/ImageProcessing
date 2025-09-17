namespace ImageProcessing
{
    public partial class Form1 : Form
    {
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
                pictureBox3.Image = (Image)pictureBox1.Image.Clone();
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
            pictureBox3.Image = grayScale;
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
            pictureBox3.Image = inverse;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pictureBox3.Image != null)
            {
                string filePath = "C:\\Users\\austi\\Downloads\\saved_image.jpg";
                try
                {
                    pictureBox3.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
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
    }
}
