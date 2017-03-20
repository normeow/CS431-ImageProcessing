using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.ColorTrasforms
{
    class GrayScaleTransformer : ColorTransformCreator
    {
        public override Bitmap Transform(Bitmap bmp)
        {
            var res = new Bitmap(bmp);
            var h = res.Height;
            var w = res.Width;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var clr = res.GetPixel(i, j);
                    int val = (int)(0.3 * clr.R + 0.59 * clr.G+ 0.11 * clr.B);
                    Color color = Color.FromArgb(255, val, val, val);
                    res.SetPixel(i, j, color);

                }
            }
            return res;
        }
    }
}
