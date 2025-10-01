
namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            uploadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            button6 = new Button();
            openFileDialog2 = new OpenFileDialog();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 345);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(394, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 345);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(399, 345);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(399, 345);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1373, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uploadToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // uploadToolStripMenuItem
            // 
            uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            uploadToolStripMenuItem.Size = new Size(103, 22);
            uploadToolStripMenuItem.Text = "Open";
            uploadToolStripMenuItem.Click += uploadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 509);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Copy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 509);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Gray Scale";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 509);
            button3.Name = "button3";
            button3.Size = new Size(115, 23);
            button3.TabIndex = 6;
            button3.Text = "Color Inversion";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(295, 509);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Sepia";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(376, 509);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "Histogram";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(799, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(415, 345);
            panel3.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(415, 345);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(557, 387);
            button6.Name = "button6";
            button6.Size = new Size(81, 23);
            button6.TabIndex = 10;
            button6.Text = "Load Image";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // button7
            // 
            button7.Location = new Point(985, 387);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "Subtract";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(126, 387);
            button8.Name = "button8";
            button8.Size = new Size(117, 23);
            button8.TabIndex = 12;
            button8.Text = "Load Background";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(148, 416);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 13;
            button9.Text = "WebCam";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1220, 36);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(142, 22);
            button10.TabIndex = 14;
            button10.Text = "Smooth";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(1220, 62);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(142, 22);
            button11.TabIndex = 15;
            button11.Text = "Gaussian Blur";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(1220, 88);
            button12.Margin = new Padding(3, 2, 3, 2);
            button12.Name = "button12";
            button12.Size = new Size(142, 22);
            button12.TabIndex = 16;
            button12.Text = "Sharpen";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1220, 115);
            button13.Margin = new Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Size = new Size(142, 22);
            button13.TabIndex = 17;
            button13.Text = "Mean Removal";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(1220, 141);
            button14.Margin = new Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Size = new Size(142, 22);
            button14.TabIndex = 18;
            button14.Text = "Embossing";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(1220, 168);
            button15.Name = "button15";
            button15.Size = new Size(141, 23);
            button15.TabIndex = 19;
            button15.Text = "Embossing Hori/Ver";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(1220, 197);
            button16.Name = "button16";
            button16.Size = new Size(141, 23);
            button16.TabIndex = 20;
            button16.Text = "Embossing All Dir";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Location = new Point(1220, 226);
            button17.Name = "button17";
            button17.Size = new Size(141, 23);
            button17.TabIndex = 21;
            button17.Text = "Embossing Lossy";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(1220, 255);
            button18.Name = "button18";
            button18.Size = new Size(141, 23);
            button18.TabIndex = 22;
            button18.Text = "Embossing Hori";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Location = new Point(1220, 284);
            button19.Name = "button19";
            button19.Size = new Size(141, 23);
            button19.TabIndex = 23;
            button19.Text = "Embossing Ver";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 554);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(panel3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Image Processing";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem uploadToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button3;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Button button6;
        private OpenFileDialog openFileDialog2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
    }
}
