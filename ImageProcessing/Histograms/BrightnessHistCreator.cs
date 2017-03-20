using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Histograms
{
    class BrightnessHistCreator : ImageHistogramCreator
    {
        public BrightnessHistCreator(Bitmap bmp)
        {
            CollectData(bmp);
        }

        protected override void CollectData(Bitmap bmp)
        {
            base.CollectData(bmp);
            var h = bmp.Height;
            var w = bmp.Width;
            var len = w * h;
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    var clr = bmp.GetPixel(i, j);
                    var brightness = (int)(0.3 * clr.R + 0.59 * clr.G + 0.11 * clr.B);
                    histdata[brightness] += 1;
                }
        }
    }
}
