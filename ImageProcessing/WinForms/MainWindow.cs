﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing.Histograms;
using ImageProcessing.ColorTrasforms;

namespace ImageProcessing.WinForms
{
    public partial class MainWindow : Form
    {
        ImageProcessingFacade imageProcessingFacade;
        ImageHistogramsFacade imageHistogramsFacade;
        Data data;
        Dictionary<string, Channel> channelDict;
        Dictionary<Channel, Color> colors;

        public static List<string> channels;
        public MainWindow()
        {
            InitializeComponent();
            initialBindings();
            rb_log.Checked = true;
            comboBox1.SelectedIndex = 3;

        }

        private void initialBindings()
        {

            imageProcessingFacade = ImageProcessingFacade.GetInstance();
            imageHistogramsFacade = new ImageHistogramsFacade();
            data = Data.Instance;

            channels = new List<string>(){ "Red", "Green", "Blue", "All" };
            channelDict = new Dictionary<string, Channel>();
            channelDict.Add("Red", Channel.R);
            channelDict.Add("Green", Channel.G);
            channelDict.Add("Blue", Channel.B);
            channelDict.Add("All", Channel.ALL);

            colors = new Dictionary<Channel, Color>();
            colors.Add(Channel.R, Color.Red);
            colors.Add(Channel.G, Color.Green);
            colors.Add(Channel.B, Color.Blue);
            colors.Add(Channel.ALL, Color.Black);
               
            data.Set(Constants.currentHistMode, Histmode.Log);
            data.Set(Constants.currentChannel, Channel.ALL);
            data.Set(Constants.image, null);

            
            data.BindChangeField(Constants.image, updatepicBox);
            data.BindChangeField(Constants.image, updateHistView);
            data.BindChangeField(Constants.currentChannel, updateHistView);
            data.BindChangeField(Constants.currentHistMode, updateHistView);
        }

        private void uploadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = Constants.imageFilterName;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog.FileName);
                imageHistogramsFacade.SetImage(bmp);
                data.Set(Constants.image, bmp);
            }

        }

        private void rb_linear_CheckedChanged(object sender, EventArgs e)
        {
            data.Set(Constants.currentHistMode, Histmode.Lin);
        }

        private void rb_log_CheckedChanged(object sender, EventArgs e)
        {
            data.Set(Constants.currentHistMode, Histmode.Log);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Set(Constants.currentChannel, channelDict[(string)comboBox1.SelectedItem]);
        }

        private void grayWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayWorldTransformWindow window = new GrayWorldTransformWindow();
            window.Show();
        }

        private void referenceColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RefColorTransformWindow window = new RefColorTransformWindow();
            window.Show();
        }

        private void equlizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.Set(Constants.image, imageProcessingFacade.Equalize(data.Get<Bitmap>(Constants.image)));
        }


        private void toGrayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.Set(Constants.image, imageProcessingFacade.ColorTransform(new GrayScaleTransformer(), data.Get<Bitmap>(Constants.image)));
        }

        private void normalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.Set(Constants.image, imageProcessingFacade.Normalize(data.Get<Bitmap>(Constants.image)));
        }

        private void quantizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrightnessQuantization window = new BrightnessQuantization();
            window.Show();
        }

        private void updatepicBox()
        {
            pictureBox1.Image = data.Get<Bitmap>(Constants.image);
        }

        private void updateHistView()
        {
            if (data.Get(Constants.image) == null)
                return;
            var channel = data.Get<Channel>(Constants.currentChannel);
            var mode = data.Get<Histmode>(Constants.currentHistMode);
            var color = colors[channel];
            histView.Image = imageHistogramsFacade.GetHistogram(channel, color, mode);
        }

        private void manualTresholdInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualBinarizationWindow window = new ManualBinarizationWindow();
            window.Show();
        }
    }
}
