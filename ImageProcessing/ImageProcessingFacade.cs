using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Histograms;
using System.Drawing;

namespace ImageProcessing
{
    public enum Channel
    {
        R,
        G,
        B
    }

    public enum Histmode
    {
        Log,
        Lin
    }

    class ImageProcessingFacade
    {
        private Dictionary<Channel, ImageHistogramCreator> hists;
        private Bitmap bmp;
        private Histmode mode;

        private static ImageProcessingFacade instance;

        private ImageProcessingFacade() {}

        public static ImageProcessingFacade getInstance()
        {
            if (instance == null)
            {
                instance = new ImageProcessingFacade();
                instance.setAllHists();
            }
            return instance;
        }

        public void setMode(Histmode mode)
        {
            this.mode = mode;
        }
        
        public Bitmap getHist(Bitmap bmp, Channel channel, Color clr)
        {
            return hists[channel].getHist(bmp, clr, mode);
        }

        private void setAllHists()
        {
            hists = new Dictionary<Channel, ImageHistogramCreator>();
            hists.Add(Channel.R, new ChannelHistCreator(Channel.R));
            hists.Add(Channel.G, new ChannelHistCreator(Channel.G));
            hists.Add(Channel.B, new ChannelHistCreator(Channel.B));

        }
    }
}
