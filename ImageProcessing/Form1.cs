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
            if (isCameraRunning && webcamDevice != null)
            {
                CaptureFromWebcamForProcessing();
            }
            applyGrayScale();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isCameraRunning && webcamDevice != null)
            {
                CaptureFromWebcamForProcessing();
            }
            applyInversion();
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
            if (isCameraRunning && webcamDevice != null)
            {
                CaptureFromWebcamForProcessing();
            }
            ApplySepiaFilter();
        }

        private void CaptureFromWebcamForProcessing()
        {
            try
            {
                webcamDevice.Sendmessage();
                System.Threading.Thread.Sleep(100); 

                if (Clipboard.ContainsImage())
                {
                    pictureBox1.Image?.Dispose(); 
                    pictureBox1.Image = (Image)Clipboard.GetImage().Clone();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capturing from webcam: {ex.Message}", "Capture Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void applyInversion()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image or start the webcam first.", "No Image",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Bitmap source = new Bitmap(pictureBox1.Image);
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
                pictureBox2.Image?.Dispose();
                pictureBox2.Image = inverse;
                this.Text = "ImageProcessing";
                source.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying sepia filter: {ex.Message}", "Processing Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Text = "ImageProcessing";
            }
        }

        private void applyGrayScale()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image or start the webcam first.", "No Image",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Bitmap source = new Bitmap(pictureBox1.Image);
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

                pictureBox2.Image?.Dispose();
                pictureBox2.Image = grayScale;
                this.Text = "ImageProcessing";
                source.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying sepia filter: {ex.Message}", "Processing Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Text = "ImageProcessing"; 
            }
        }
        private void ApplySepiaFilter()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image or start the webcam first.", "No Image",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Bitmap source = new Bitmap(pictureBox1.Image); 
                Bitmap sepia = new Bitmap(source.Width, source.Height);

                for (int x = 0; x < source.Width; x++)
                {
                    for (int y = 0; y < source.Height; y++)
                    {
                        Color pixelColor = source.GetPixel(x, y);

                        int tr = (int)(0.393 * pixelColor.R + 0.769 * pixelColor.G + 0.189 * pixelColor.B);
                        int tg = (int)(0.349 * pixelColor.R + 0.686 * pixelColor.G + 0.168 * pixelColor.B);
                        int tb = (int)(0.272 * pixelColor.R + 0.534 * pixelColor.G + 0.131 * pixelColor.B);

                        tr = Math.Min(255, Math.Max(0, tr));
                        tg = Math.Min(255, Math.Max(0, tg));
                        tb = Math.Min(255, Math.Max(0, tb));

                        Color newColor = Color.FromArgb(pixelColor.A, tr, tg, tb);
                        sepia.SetPixel(x, y, newColor);
                    }
                }

                pictureBox2.Image?.Dispose();
                pictureBox2.Image = sepia;
                this.Text = "ImageProcessing";
                source.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying sepia filter: {ex.Message}", "Processing Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Text = "ImageProcessing";
            }
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
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                StopWebcam();
            }
        }

        private WebCamLib.Device webcamDevice;
        private WebCamLib.Device[] webcamDevices;
        private bool isCameraRunning = false;

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isCameraRunning)
                {
                    StartWebcam();
                }
                else
                {
                    StopWebcam();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Webcam error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartWebcam()
        {
            WebCamLib.Device[] devices = WebCamLib.DeviceManager.GetAllDevices();

            if (devices.Length == 0)
            {
                MessageBox.Show("No webcam devices found!", "No Camera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            webcamDevice = devices[0];
            webcamDevice.ShowWindow(pictureBox1);

            button9.Text = "Stop Camera";
            isCameraRunning = true;

        }

        private void StopWebcam()
        {
            if (webcamDevice != null)
            {
                webcamDevice.Stop();
                webcamDevice = null;
            }

            button9.Text = "Start Camera";
            isCameraRunning = false;

            MessageBox.Show("Camera stopped", "Camera Stopped",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
