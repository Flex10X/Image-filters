using Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Image_Browser;
using System.ComponentModel;

namespace Image_Browser
{
    internal class Turn : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            double angle = 0.3;
            int x_0 = sourceImage.Width / 2;
            int y_0 = sourceImage.Height / 2;
            int x = (int)((k-x_0)*Math.Cos(angle) - (l - y_0)*Math.Sin(angle)+ x_0);
            int y = (int)((k - x_0) * Math.Sin(angle) - (l - y_0) * Math.Cos(angle) + y_0);
            Color resultColor = sourceImage.GetPixel(Clamp(x, 0, sourceImage.Width - 1), Clamp(y, 0, sourceImage.Height - 1));
            return resultColor;


        }
    }
}