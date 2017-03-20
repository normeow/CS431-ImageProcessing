using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing.WinForms
{
    public partial class ManualBinarizationWindow : Form
    {
        private enum BinarizationMode
        {
            Upper,
            Lower,
            Range
        }
        private BinarizationMode currentMode;
        private Data data;
        private ImageProcessingFacade imageProcessingFacade;

        public ManualBinarizationWindow()
        {
            InitializeComponent();
            radioButtonUpper.Checked = true;
            imageProcessingFacade = ImageProcessingFacade.GetInstance();
            data = Data.Instance;
            srcImage.Image = data.Get<Bitmap>(Constants.image);
            
        }

        private void btnBinarize_Click(object sender, EventArgs e)
        {
            Bitmap res = null;
            switch (currentMode)
            {
                case BinarizationMode.Lower:
                    res = imageProcessingFacade.BinarizeLowerThreshold(data.Get<Bitmap>(Constants.image), (int)lowerThershold.Value);
                    break;

                case BinarizationMode.Upper:
                    res = imageProcessingFacade.BinarizeUpperThreshold(data.Get<Bitmap>(Constants.image), (int)upperThershold.Value);
                    break;
                case BinarizationMode.Range:
                    res = imageProcessingFacade.BinarizeRangeThreshold(data.Get<Bitmap>(Constants.image), (int)rangeThersholdFrom.Value, (int) rangeThersholdTo.Value);
                    break;
            }
            //TODO ALL IN MODEL !!!!
            destImage.Image = res;
        }

        private void radioButtonUpper_CheckedChanged(object sender, EventArgs e)
        {
            currentMode = BinarizationMode.Upper;
        }

        private void radioButtonLower_CheckedChanged(object sender, EventArgs e)
        {
            currentMode = BinarizationMode.Lower;
        }

        private void radioButtonRange_CheckedChanged(object sender, EventArgs e)
        {
            currentMode = BinarizationMode.Range;
        }
    }
}
