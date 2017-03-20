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
    public partial class RefColorTransformWindow : Form
    {
        Data data;
        Bitmap bmp;

        public RefColorTransformWindow()
        {
            InitializeComponent();
            data = Data.Instance;
            bmp = data.Get<Bitmap>(Constants.image);
            pictureBox1.Image = bmp;
            data.Set(Constants.srcColor, srcPicBox.BackColor);
            data.Set(Constants.destColor, destPicBox.BackColor);
            data.BindChangeField(Constants.srcColor, updateSrcClr);
            data.BindChangeField(Constants.destColor, updateDestClr);
        }

        private void btnPickDestClr_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            data.Set(Constants.destColor, colorDialog1.Color);

        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            var src = data.Get<Color>(Constants.srcColor);
            var dest = data.Get<Color>(Constants.destColor);
            ColorTransformCreator refColor = new ReferenceColor(src, dest);
            bmp = refColor.Transform(bmp);
            pictureBox1.Image = bmp;


        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            data.Set(Constants.srcColor, bmp.GetPixel(e.X, e.Y));

        }

        private void updateSrcClr()
        {
            var clr = data.Get<Color>(Constants.srcColor);
            srcPicBox.BackColor = clr;
        }

        private void updateDestClr()
        {
            var clr = data.Get<Color>(Constants.destColor);
            destPicBox.BackColor = clr;
        }
    }
}
