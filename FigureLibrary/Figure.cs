using System.Drawing;
using FigureLibrary.Extensions;
using FigureLibrary.Interfaces;

namespace FigureLibrary
{
    public abstract class Figure: IHasArea
    {
        private Size _size;
        public abstract double GetArea();
        public Size Size { get => _size; protected set => _size = value.IsNotNegative() ? value : Size.Empty; }
    }
}
