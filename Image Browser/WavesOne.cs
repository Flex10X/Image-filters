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
    internal class WavesOne : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {

            int x = (int)(k + 20 * Math.Sin(2 * Math.PI * l / 60));
            int y = l;
            Color resultColor = sourceImage.GetPixel(Clamp(x, 0, sourceImage.Width - 1), Clamp(y, 0, sourceImage.Height - 1));
            return resultColor;
        }
    }
}