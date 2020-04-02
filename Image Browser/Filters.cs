using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Image_Browser;
using System.ComponentModel;


namespace Filters
{
    abstract class Filter
    {
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);
        public virtual Bitmap proccesImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }
        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

    }
    class InvertFilter : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
            return resultColor;

        }
    }
    class MatrixFilter : Filter
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
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
                                             Clamp((int)resultR, 0, 255),
                                             Clamp((int)resultG, 0, 255),
                                             Clamp((int)resultB, 0, 255)
                                             );
        }




    }

    class BlurFilter : MatrixFilter
    {
        public BlurFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeX; j++)
                    kernel[i, j] = 1.0f / (float)(sizeX * sizeY);
        }
    }
    class GaussianFilter : MatrixFilter
    {
        public void createGaussianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1;
            kernel = new float[size, size];
            float norm = 0;
            for (int i = -radius; i <= radius; i++)
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;
        }
        public GaussianFilter()
        {
            createGaussianKernel(3, 2);
        }
    }
    class GrayScaleFilter : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double Intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
            Color resultColor = Color.FromArgb((int)(Intensity),
                                           (int)(Intensity),
                                           (int)(Intensity));
            return resultColor;


        }

    }
    class SepiaFilter : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double resultR = 0;
            double resultG = 0;
            double resultB = 0;
            double k = 70;
            Color sourceColor = sourceImage.GetPixel(x, y);
            double Intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
            resultR = Intensity + 2 * k;
            resultG = Intensity + 0.5 * k;
            resultB = Intensity - 1 * k;
            return Color.FromArgb(
                                            Clamp((int)resultR, 0, 255),
                                            Clamp((int)resultG, 0, 255),
                                            Clamp((int)resultB, 0, 255)
                                            );

        }
    }
    class HighBrightness : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            const int c = 145;
            return Color.FromArgb(
                                           Clamp((int)(sourceColor.R + c), 0, 255),
                                           Clamp((int)(sourceColor.G + c), 0, 255),
                                           Clamp((int)(sourceColor.B + c), 0, 255)
                                           );

        }
    }
    class SobelFilter : MatrixFilter
    {

        public SobelFilter(char oper)
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            if (oper == 'Y')
            {
                kernel[0, 0] = -1; kernel[0, 1] = 0; kernel[0, 2] = 1;
                kernel[1, 0] = -2; kernel[1, 1] = 0; kernel[1, 2] = 2;
                kernel[2, 0] = -1; kernel[2, 1] = 0; kernel[2, 2] = 1;
            }
            else
            {
                kernel[0, 0] = -1; kernel[0, 1] = -2; kernel[0, 2] = -1;
                kernel[1, 0] = 0; kernel[1, 1] = 0; kernel[1, 2] = 0;
                kernel[2, 0] = 1; kernel[2, 1] = 2; kernel[2, 2] = 1;

            }
        }
    }
    class SharpnessFilter : MatrixFilter
    {
        public SharpnessFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = 0; kernel[0, 1] = -1; kernel[0, 2] = 0;
            kernel[1, 0] = -1; kernel[1, 1] = 5; kernel[1, 2] = -1;
            kernel[2, 0] = 0; kernel[2, 1] = -1; kernel[2, 2] = 0;
            

        }
    }
    class PerfectReflector : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double maxsourceColorR = 0;
            double maxsourceColorG = 0;
            double maxsourceColorB = 0;
            Color sourceColor = sourceImage.GetPixel(x, y);
            if (maxsourceColorR < sourceColor.R)
                maxsourceColorR = sourceColor.R;
            if (maxsourceColorG < sourceColor.G)
                maxsourceColorG = sourceColor.G;
            if (maxsourceColorB < sourceColor.B)
                maxsourceColorB = sourceColor.B;
            return Color.FromArgb(
                                           Clamp((int)(sourceColor.R*(255/maxsourceColorR)), 0, 255),
                                           Clamp((int)(sourceColor.G*(255/maxsourceColorG)), 0, 255),
                                           Clamp((int)(sourceColor.B*(255/maxsourceColorB)), 0, 255)
                                           );


        }
    }
    class AutoLevels : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            return new Color();
        }
        public override Bitmap proccesImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            float max_R = 0, max_G = 0, max_B = 0, min_R = 255, min_G = 255, min_B = 255;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                   if (sourceImage.GetPixel(i, j).R < min_R)
                    {
                        min_R = sourceImage.GetPixel(i, j).R;
                    }
                    if (sourceImage.GetPixel(i, j).G < min_G)
                    {
                        min_G = sourceImage.GetPixel(i, j).G;
                    }
                    if (sourceImage.GetPixel(i, j).B < min_B)
                    {
                        min_B = sourceImage.GetPixel(i, j).B;
                    }
                    if (sourceImage.GetPixel(i, j).R > max_R)
                    {
                        max_R = sourceImage.GetPixel(i, j).R;
                    }
                    if (sourceImage.GetPixel(i, j).G > max_G)
                    {
                        max_G = sourceImage.GetPixel(i, j).G;
                    }
                    if (sourceImage.GetPixel(i, j).B > max_B)
                    {
                        max_B = sourceImage.GetPixel(i, j).B;
                    }
                }

            }
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color color = Color.FromArgb(
                           Clamp((int)((sourceImage.GetPixel(i, j).R - min_R) * 255 / (max_R - min_R)), 0, 255),
                           Clamp((int)((sourceImage.GetPixel(i, j).G - min_G) * 255 / (max_G - min_G)), 0, 255),
                           Clamp((int)((sourceImage.GetPixel(i, j).B - min_B) * 255 / (max_B - min_B)), 0, 255));
                    resultImage.SetPixel(i, j, color);
                }
            }
            return resultImage;


        }
       
    }
            }
