﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing.ColorTrasforms
{
    abstract class ColorTransformCreator
    {
        public abstract Bitmap transform(Bitmap bp);

        protected int normalizeColorValue(int value)
        {
            if (value < 0)
                return 0;
            if (value > 255)
                return 255;
            return value;
        }
    }
}
