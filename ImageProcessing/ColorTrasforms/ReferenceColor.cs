using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.ColorTrasforms
{
    class ReferenceColor : ColorTransformCreator
    {
        Color srcColor, destColor;
        public ReferenceColor(Color srcColor, Color destColor)
        {
            this.srcColor = srcColor;
            this.destColor = destColor;
        }

        public override Bitmap Transform(Bitmap bmp)
        {
            var res = new Bitmap(bmp);
            var h = res.Height;
            var w = res.Width;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var cur_clr = res.GetPixel(i, j);
                    int r = NormalizeColorValue(cur_clr.R * destColor.R / srcColor.R);
                    int g = NormalizeColorValue(cur_clr.G * destColor.G / srcColor.G);
                    int b = NormalizeColorValue(cur_clr.B * destColor.B / srcColor.B);
                    Color clr = Color.FromArgb(255, r, g, b);
                    res.SetPixel(i, j, clr);

                }
            }
            return res;
        }
    }
}
