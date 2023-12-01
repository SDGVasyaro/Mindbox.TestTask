using FigureLibrary.Enums;
using System.Drawing;


namespace FigureLibrary
{
    internal class TriangleCalculator
    {
        private Triangle _triangle;
        internal TriangleCalculator(Triangle triangle)
        {
            _triangle = triangle;
        }
        public bool IsExistedTriangle => _triangle.SidesLength.All(IsSideExisted);
        public double CalculateArea()
        {
            var halfPerimetr = _triangle.SidesLength.Sum() / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - _triangle.SidesLength[0]) * (halfPerimetr - _triangle.SidesLength[1]) * (halfPerimetr - _triangle.SidesLength[2]));
        }

        public TriangleType CalculateTriangleType()
        {
            int firstSide = _triangle.SidesLength[0];
            if (_triangle.SidesLength.Skip(1).All(s => firstSide == s))
                return TriangleType.Equilateral;
            bool isRight = _triangle.SidesLength.Any(IsHypotenuse);
            bool isIsosceles = _triangle.SidesLength.Skip(1).Any(s => firstSide == s);
            bool isRightAndIsosceles = isRight && isIsosceles;
            if (isRightAndIsosceles)
                return TriangleType.RightAndIsosceles;
            if (isRight)
                return TriangleType.Right;
            if (isIsosceles)
                return TriangleType.Isosceles;
            return TriangleType.None;
        }
        
        public Size CalculateSize()
        {
            var baseSide = _triangle.SidesLength.Max();
            var height=2.0/baseSide*CalculateArea();
            return new Size(baseSide, (int)height);
        }

        private bool IsHypotenuse(int side)
        {
            var exceptedSides = _triangle.SidesLength.ToList();
            exceptedSides.Remove(side);
            return Math.Pow(side, 2) == Math.Pow(exceptedSides[0], 2) + Math.Pow(exceptedSides[1], 2);
        }
        private bool IsSideExisted(int side)
        {
            var exceptedSides = _triangle.SidesLength.ToList();
            exceptedSides.Remove(side);
            return side < exceptedSides[0] + exceptedSides[1];
        }

        
    }
}
