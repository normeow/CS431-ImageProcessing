using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing.Histograms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        ImageProcessingFacade imProcFacade;
        public Form1()
        {
            InitializeComponent();
            imProcFacade = ImageProcessingFacade.getInstance();
            rb_log.Checked = true;
            comboBox1.SelectedIndex = 0;

        }

        private void uploadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = bmp;
                pictureBox2.Image = imProcFacade.getHist(bmp, Channel.R, Color.Red);
            }

        }

        private void rb_linear_CheckedChanged(object sender, EventArgs e)
        {
            imProcFacade.setMode(Histmode.Lin);
        }

        private void rb_log_CheckedChanged(object sender, EventArgs e)
        {
            imProcFacade.setMode(Histmode.Log);
        }
        
    }
}
