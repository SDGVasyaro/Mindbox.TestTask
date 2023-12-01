using FigureLibrary.Enums;
using FigureLibrary.Extensions;

namespace FigureLibrary
{
    public sealed class Triangle : Figure
    {
        public readonly TriangleType Type;
        public readonly int[] SidesLength = new int[3];
        private TriangleCalculator calculator;
        public Triangle(int firstSideLenght, int secondSideLenght, int thirdSideLenght) 
        {
            SidesLength[0] = firstSideLenght.ZeroIfNegative();
            SidesLength[1] = secondSideLenght.ZeroIfNegative();
            SidesLength[2] = thirdSideLenght.ZeroIfNegative();
            calculator = new(this);
            if (!calculator.IsExistedTriangle)
            {
                throw new ArgumentException("One side of a triangle is greater than the sum of the other two sides. " +
                                            "Such a triangle cannot exist.");
            }
            Type = calculator.CalculateTriangleType();
            Size=calculator.CalculateSize();
        }
        #region Figure
        public override double GetArea()
        {
            return calculator.CalculateArea();
        }
        #endregion
    }
}
