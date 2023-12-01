using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Extensions
{
    internal static class SizeExtension
    {
        internal static bool IsNotNegative(this Size size)
        {
            return size.Width >= 0 && size.Height >= 0;
        }

    }
}
