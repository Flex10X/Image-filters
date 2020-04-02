using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filters;



namespace Image_Browser
{
    public partial class Form1 : Form
    {
        Bitmap Image;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image = new Bitmap(dialog.FileName);
            }
            pictureBox1.Image = Image;
            pictureBox1.Refresh();
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter Filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(Filter);
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filter)e.Argument).proccesImage(Image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                Image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = Image;
                pictureBox1.Refresh();
            }

            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void гауссToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void вышеЯркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new HighBrightness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void собельToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void операторПоОсиYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char oper = 'Y';
            Filter filter = new SobelFilter(oper);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void операторПоОсиXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char oper = 'X';
            Filter filter = new SobelFilter(oper);
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void htprjcnmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void идеальныйОтражательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new PerfectReflector();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void растяжениеКонтрастностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new AutoLevels();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void волны1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new WavesOne();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Turn();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void волны2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new WavesTwo();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Emboss();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Dilation();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Erosion();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сдвигВЛевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new ShiftLeft();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сдвигВправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new ShiftRight();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void операторЩарраToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void поОсиYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char axis = 'Y';
            Filter filter = new Scharr(axis);
            backgroundWorker1.RunWorkerAsync(filter);



        }

        private void поОсиXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char axis = 'X';
            Filter filter = new Scharr(axis);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поОсиYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            char axis = 'Y';
            Filter filter = new Prewitt(axis);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поОсиXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            char axis = 'X';
            Filter filter = new Prewitt(axis);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);

        }
    }

  
}
