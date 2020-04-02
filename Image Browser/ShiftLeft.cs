using Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_Browser
{
    internal class ShiftLeft : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int par = 50;

            Color resultColor;

            int k = Clamp(x + par, 0, sourceImage.Width - 1);
            int l = y;
            if ((k < sourceImage.Width) && (k > sourceImage.Width - par))
            { resultColor = Color.LightBlue; }
            else
            { resultColor = sourceImage.GetPixel(k, l); }

            return resultColor;
        }
    }
}