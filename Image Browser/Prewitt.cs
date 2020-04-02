using Filters;

namespace Image_Browser
{
    internal class Prewitt : MatrixFilter
    {
        public Prewitt(char axis)
        {
            int sizeY = 3;
            int sizeX = 3;
            kernel = new float[sizeX, sizeY];
            if(axis == 'Y')
            {
                kernel[0, 0] = -1; kernel[0, 1] = -1; kernel[0, 2] = -1;
                kernel[1, 0] = 0; kernel[1, 1] = 0; kernel[1, 2] = 0;
                kernel[2, 0] = 1; kernel[2, 1] = 1; kernel[2, 2] = 1;
            }
            else
            {
                kernel[0, 0] = -1; kernel[0, 1] = 0; kernel[0, 2] = 1;
                kernel[1, 0] = -1; kernel[1, 1] = 0; kernel[1, 2] = 1;
                kernel[2, 0] = -1; kernel[2, 1] = 0; kernel[2, 2] = 1;
            }
        }
        
    }
}