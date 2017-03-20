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
    class ImageProcessingFacade
    {
        

        private static ImageProcessingFacade instance;

        private ImageProcessingFacade() { }

        public static ImageProcessingFacade getInstance()
        {
            if (instance == null)
            {
                instance = new ImageProcessingFacade();
            }
            return instance;
        }
        
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
            return transformer.Transform(bmp);
        }

        public Bitmap Quantize(Bitmap bmp, int levels)
        {

            double step = 256 / levels;
            var res = new Bitmap(bmp);
            var h = bmp.Height;
            var w = bmp.Width;
            var len = w * h;
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    var clr = bmp.GetPixel(i, j);
                    //TODO something? I write this code too often. What about wrapper for color? And check getBrightness property.
                    var brightness = (int)(0.3 * clr.R + 0.59 * clr.G + 0.11 * clr.B);
                    var new_r = (int)(Math.Round(clr.R/(step)) * step);
                    var new_g = (int)(Math.Round(clr.G / (step)) * step);
                    var new_b = (int)(Math.Round(clr.B/ (step)) * step);
                    res.SetPixel(i, j, Color.FromArgb(255, new_r, new_g, new_g));


                }
            return res;
        }
    }
}
