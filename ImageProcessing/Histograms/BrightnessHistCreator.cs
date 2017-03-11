﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Histograms
{
    class BrightnessHistCreator : ImageHistogramCreator
    {
        protected override void collectData(Bitmap bmp)
        {
            histdata = new int[256];
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