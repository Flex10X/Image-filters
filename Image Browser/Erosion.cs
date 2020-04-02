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
    internal class Erosion : MatrixFilter
    {
        public Erosion()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];


            kernel[0, 0] = 0.1f;
            kernel[0, 1] = 0.1f;
            kernel[0, 2] = 0.1f;
            kernel[1, 0] = 0.1f;
            kernel[1, 1] = 0.1f;
            kernel[1, 2] = 0.1f;
            kernel[2, 0] = 0.1f;
            kernel[2, 1] = 0.1f;
            kernel[2, 2] = 0.1f;
        }

    }
}