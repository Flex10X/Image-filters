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
    internal class GlassEffect : Filter
    {
        Random rnd = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {


            Color sourceColor = sourceImage.GetPixel(k, l);
            int x = Clamp((int)(k + (rnd.Next(2) - 0.5) * 15), 0, sourceImage.Width - 1);
            int y = Clamp((int)(l + (rnd.Next(1) - 0.5) * 15), 0, sourceImage.Width - 1);
            Color resultColor = sourceImage.GetPixel(x, y);
            return resultColor;
        }
    }
}