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

        public static ImageProcessingFacade GetInstance()
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
            Image<Gray, byte> imageL = image[1];
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
                    var new_r = (int)(Math.Round(clr.R/(step)) * step);
                    var new_g = (int)(Math.Round(clr.G / (step)) * step);
                    var new_b = (int)(Math.Round(clr.B/ (step)) * step);
                    res.SetPixel(i, j, Color.FromArgb(255, new_r, new_g, new_g));


                }
            return res;
        }

        /// <summary>
        /// Pixels with brithness less than threshholdValue are black, others - white
        /// </summary>
        public Bitmap BinarizeUpperThreshold(Bitmap bmp, int treshhold_value)
        {
            Image<Gray, byte> image = new Image<Gray, byte>(bmp);
            Bitmap res = image.ThresholdBinary(new Gray(treshhold_value), new Gray(255)).ToBitmap();
            return res;
        }

        public Bitmap BinarizeLowerThreshold(Bitmap bmp, int treshhold_value)
        {
            Image<Gray, byte> image = new Image<Gray, byte>(bmp);
            Bitmap res = image.ThresholdBinaryInv(new Gray(treshhold_value), new Gray(255)).ToBitmap();
            return res;
        }

        public Bitmap BinarizeRangeThreshold(Bitmap bmp, int lower, int upper)
        {
            // All in range [lower, upper] = BLACK = 0
            Image<Gray, byte> image = new Image<Gray, byte>(bmp);
            image = image.ThresholdBinaryInv(new Gray(upper), new Gray(255));
            image = image.ThresholdBinary(new Gray(lower), new Gray(255));
            Bitmap res = image.Not().ToBitmap();
            return res;
        }




    }
}
