using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Histograms;
using System.Drawing;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using ImageProcessing.ColorTrasforms;

namespace ImageProcessing
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

    class ImageProcessingFacade
    {
        private Dictionary<Channel, ImageHistogramCreator> hists;
        private Bitmap bmp;

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
        
        public Bitmap getHist(Bitmap bmp, Channel channel, Histmode mode, Color clr)
        {
            return hists[channel].getHist(bmp, clr, mode);
        }

        private void setAllHists()
        {
            hists = new Dictionary<Channel, ImageHistogramCreator>();
            hists.Add(Channel.R, new ChannelHistCreator(Channel.R));
            hists.Add(Channel.G, new ChannelHistCreator(Channel.G));
            hists.Add(Channel.B, new ChannelHistCreator(Channel.B));
            hists.Add(Channel.ALL, new BrightnessHistCreator());
        }


        //awfull
        public Bitmap Equalize(Bitmap bmp)
        {
            Image<Hls, byte> image = new Image<Hls, byte>(bmp);
            Image<Gray, Byte> imageL = image[1];
            imageL._EqualizeHist();
            image[1] = imageL;
            Image<Bgr, byte> resimg = image.Convert<Bgr, byte>();
            return resimg.ToBitmap();
        }

        public Bitmap Normalize(Bitmap bmp)
        {
            Image<Hls, byte> image = new Image<Hls, byte>(bmp);
            Image<Gray, Byte> imageL = image[1];
            CvInvoke.Normalize(imageL, imageL, 255, 0, Emgu.CV.CvEnum.NormType.MinMax);
            image[1] = imageL;
            Image<Bgr, byte> resimg = image.Convert<Bgr, byte>();
            return resimg.ToBitmap();
        }

        public Bitmap ColorTransform(ColorTransformCreator transformer, Bitmap bmp)
        {
            return transformer.transform(bmp);
        }
    }
}
