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

        public override Bitmap transform(Bitmap bp)
        {
            var res = new Bitmap(bp);
            var h = res.Height;
            var w = res.Width;
            for (int i =0; i< w; i++)
            {

            }

            return res;

        }

        private void countAvg(Bitmap bp)
        {

        }
    }
}
