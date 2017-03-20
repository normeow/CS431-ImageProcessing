using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing.ColorTrasforms;

namespace ImageProcessing
{
    public partial class GrayWorldTransformWindow : Form
    {

        public GrayWorldTransformWindow()
        {
            InitializeComponent();
            
            Bitmap bmp =  Data.Instance.Get<Bitmap>(Constants.image);
            ColorTransformCreator transformer = new GrayWorld();
            pictureBox1.Image = transformer.Transform(bmp);
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = Constants.imageFilterName;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                pictureBox1.Image.Save(path);
            }
        }
    }
}
