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
    internal class Emboss : MatrixFilter
    {
    
        public Emboss()
        {


            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = 0; kernel[0, 1] = 1; kernel[0, 2] = 0;
            kernel[1, 0] = 1; kernel[1, 1] = 0; kernel[1, 2] = -1;
            kernel[2, 0] = 0; kernel[2, 1] = -1; kernel[2, 2] = 0;


        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int I = -radiusY; I <= radiusY; I++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + I, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radiusX, I + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, I + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, I + radiusY];





                }
                
            }
           
            return Color.FromArgb(
                                             Clamp((int)resultR + 128, 0, 255),
                                             Clamp((int)resultG + 128, 0, 255),
                                             Clamp((int)resultB + 128, 0, 255)
                                             );
        }
    }
}