using Filters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Image_Browser;
using System.ComponentModel;

namespace Image_Browser
{
    internal class Dilation : MatrixFilter
    {
        
        public Dilation()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];

           

            kernel[0, 0] = 0; kernel[0, 1] = 1; kernel[0, 2] = 0;
            kernel[1, 0] = 1; kernel[1, 1] = 1; kernel[1, 2] = 1;
            kernel[2, 0] = 0; kernel[2, 1] = 1; kernel[2, 2] = 0;
        }
    }
}