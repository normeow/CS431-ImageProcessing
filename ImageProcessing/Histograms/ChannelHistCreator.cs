using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing.Histograms
{
    class ChannelHistCreator : ImageHistogramCreator
    {
        Channel channel;

        public ChannelHistCreator(Channel channel)
        {
            this.channel = channel;
        }

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
                    //get channel value
                    int val = (int)clr.GetType().GetProperty(channel.ToString()).GetValue(clr);
                    histdata[val] += 1;
                }
        }
    }
}
