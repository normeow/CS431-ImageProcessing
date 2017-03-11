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
                    
                    int val = -1;
                    if (channel == Channel.R)
                        val = clr.R;
                    else if (channel == Channel.G)
                        val = clr.G;
                    else if (channel == Channel.B)
                        val = clr.B;
                    histdata[val] += 1;
                }
        }
    }
}
