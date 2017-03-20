using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing.Histograms
{
    public enum Channel
    {
        R,
        G,
        B,
        ALL
    }

    public enum Histmode
    {
        Log,
        Lin
    }

    class ImageHistogramsFacade
    {
        private Bitmap bmp;
        private Dictionary<Channel, ImageHistogramCreator> historgamCreators;
        private Dictionary<Histmode, Dictionary<Channel, Bitmap>> cachedHistograms;
        

        public ImageHistogramsFacade() { }
        
        public void SetImage(Bitmap image)
        {
            this.bmp = image;
            SetHistogramCreators();
            SetCache();
        }

        private void SetHistogramCreators()
        {
            historgamCreators = new Dictionary<Channel, ImageHistogramCreator>();
            historgamCreators.Add(Channel.R, new ChannelHistCreator(bmp, Channel.R));
            historgamCreators.Add(Channel.G, new ChannelHistCreator(bmp, Channel.G));
            historgamCreators.Add(Channel.B, new ChannelHistCreator(bmp, Channel.B));
            historgamCreators.Add(Channel.ALL, new BrightnessHistCreator(bmp));
        }

        private void SetCache()
        {
            cachedHistograms = new Dictionary<Histmode, Dictionary<Channel, Bitmap>>();
            cachedHistograms.Add(Histmode.Lin, new Dictionary<Channel, Bitmap>());
            cachedHistograms.Add(Histmode.Log, new Dictionary<Channel, Bitmap>());
        }

        private Bitmap GetCachedHistogram(Histmode mode, Channel channel)
        {
            Bitmap res = null;
            if (cachedHistograms[mode].Keys.Contains(channel))
            {
                res = cachedHistograms[mode][channel];
            }
            
            return res;
        }

        private void SetCashedHistogram(Histmode mode, Channel channel, Bitmap histogram)
        {
            cachedHistograms[mode].Add(channel, histogram);
        }
        

        public Bitmap GetHistogram(Channel channel, Color color, Histmode mode)
        {
            Bitmap cached = GetCachedHistogram(mode, channel);
            if (cached == null)
            {
                cached = historgamCreators[channel].getHist(color, mode);
                SetCashedHistogram(mode, channel, cached);
            }

            return cached;
        }
        
    }
}
