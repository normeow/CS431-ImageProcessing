using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class BrightnessQuantization : Form
    {
        Data data;
        ImageProcessingFacade imProcFacade;
        public BrightnessQuantization()
        {   
            InitializeComponent();
            data = Data.Instance;
            imProcFacade = ImageProcessingFacade.getInstance();
            pictureBox1.Image = data.Get<Bitmap>(Constants.image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imProcFacade.Quantize(data.Get<Bitmap>(Constants.image), (int)numericUpDown1.Value);
        }
    }
}
