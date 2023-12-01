using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Extensions
{
    internal static class IntegerExtension
    {
        internal static int ZeroIfNegative(this int value)
        {
            return value >= 0 ? value : 0;
        }
    }
}
