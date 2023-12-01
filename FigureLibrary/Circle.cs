using System.Drawing;
using FigureLibrary.Extensions;

namespace FigureLibrary
{
    public class Circle : Figure
    {
        private int _radius;

        public Circle(int radius)
        {
            Radius = radius;
        }
        #region Figure
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        #endregion

        public int Radius { get => _radius; set => SetRadius(value); }

        private void SetRadius(int value)
        {
            _radius = value.ZeroIfNegative();
            Size = new Size(Radius * 2,Radius * 2);
        }
    }
}
