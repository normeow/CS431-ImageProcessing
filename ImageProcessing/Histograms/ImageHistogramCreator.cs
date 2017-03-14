using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace ImageProcessing.Histograms
{
   

    public abstract class ImageHistogramCreator
    {
        protected int[] histdata;
        private const int BITMAP_HEIGHT = 256;
        private const int BITMAP_WIDTH = 256;

        protected virtual void collectData(Bitmap bmp)
        {

            histdata = new int[256];
            for (int i = 0; i < 256; i++)
                histdata[i] = 0;

        }
        
        public Bitmap getHist(Bitmap bmp, Color clr, Histmode mode)
        {
            collectData(bmp);
            Bitmap res = new Bitmap(BITMAP_WIDTH, BITMAP_HEIGHT);
            var data = getScaled(mode);
            using (Graphics g = Graphics.FromImage(res))
            {
                Pen p = new Pen(clr);
                for (int i = 0; i < data.Length; i++)
                {
                    Point x = new Point(i, BITMAP_HEIGHT);
                    Point y = new Point(i, BITMAP_HEIGHT - data[i]);
                    g.DrawLine(p, x, y);
                    Console.WriteLine("Ok: i = {0}, x = {1}, y = {2}", i, x, y);
                }
            }
            return res;
        }

        private int[] getScaled(Histmode mode)
        {
            int[] res = new int[256];
            histdata.CopyTo(res,0);

            var max_c = res.Max();

            double k = BITMAP_HEIGHT;

            if (mode == Histmode.Lin)
                k /= max_c;
            else if (mode == Histmode.Log)
                k /= Math.Log(max_c);
            

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == 0)
                    continue;
                if (mode == Histmode.Lin)
                    res[i] = (int)Math.Round(res[i] * k);
                else if (mode == Histmode.Log)
                    res[i] = (int)Math.Round(Math.Log(res[i]) * k);

            }
            return res;
        }

        
    }
}
