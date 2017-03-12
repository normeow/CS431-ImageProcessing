using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.ColorTrasforms
{
    class GrayWorld : ColorTransformCreator
    {
        int avg_r, avg_g, avg_b, avg;

        public override Bitmap transform(Bitmap bmp)
        {
            countAvg(bmp);
            var res = new Bitmap(bmp);
            var h = res.Height;
            var w = res.Width;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var cur_clr = res.GetPixel(i, j);
                    int r = normalizeColorValue(cur_clr.R * avg / avg_r);
                    int g = normalizeColorValue(cur_clr.G * avg / avg_g);
                    int b = normalizeColorValue(cur_clr.B * avg / avg_b);
                    Color clr = Color.FromArgb(255, r, g, b);
                    res.SetPixel(i, j, clr);

                }
            }

            return res;

        }

        private void countAvg(Bitmap bmp)
        {
            var h = bmp.Height;
            var w = bmp.Width;
            var len = w * h;
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    avg_r += bmp.GetPixel(i, j).R;
                    avg_g += bmp.GetPixel(i, j).G;
                    avg_b += bmp.GetPixel(i, j).B;
                }

            avg_r = avg_r / len;
            avg_g = avg_g / len;
            avg_b = avg_b / len;
            avg = (avg_r + avg_g + avg_b) / 3;

        }
    }
}
