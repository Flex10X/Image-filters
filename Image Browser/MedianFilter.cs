using Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_Browser
{
    internal class MedianFilter : MatrixFilter
    {
        public MedianFilter()
        {
            int sizeX = 5;
            int sizeY = 5;
            kernel = new float[sizeX, sizeY];

        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;



            float[] arr = new float[25];
            Color[] arrColor = new Color[25];

            for (int i = -radiusY; i <= radiusY; i++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + i, 0, sourceImage.Height - 1);
                    arrColor[(k + radiusX) + (i + radiusY) * 5] = sourceImage.GetPixel(idX, idY);
                    arr[(k + radiusX) + (i + radiusY) * 5] = sourceImage.GetPixel(idX, idY).GetBrightness();

                }

            Array.Sort(arr);
            foreach (Color color in arrColor)
            {
                if (color.GetBrightness() == arr[12])
                {
                    return color;
                }
            }
            return arrColor[1];
        }
    }
}