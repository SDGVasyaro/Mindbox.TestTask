using FigureLibrary;
using System.Drawing;

namespace FigureLibraryUnitTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(-40)]
        [InlineData(-7)]
        public void CalculateCircleArea_ShouldReturnZero_WhenRadiusNegativeOrZero(int radius)
        {
            var _figure = new Circle(radius);
            Assert.Equal(expected: 0, (int)_figure.GetArea());
        }

        [Theory]
        [InlineData(5,78)]
        public void CalculateCircleArea_ShouldReturnArea_WhenRadiusValid(int radius,double expected)
        {
            var _figure = new Circle(radius);
            Assert.Equal(expected: expected, (int)_figure.GetArea());
        }

        [Theory]
        [InlineData(4, 1, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, -3)]
        [InlineData(-5, -5, -5)]
        public void CreateTriangle_ShouldThrowsException_WhenArgsIsNotValidSides(int sideA, int sideB, int sideC)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var _figure = new Triangle(sideA, sideB, sideC);
            });
        }

        [Theory]
        [InlineData(5, 4, 3, 6)]
        public void CalculateTriangleArea_ShouldReturnArea_WhenArgsValid(int sideA, int sideB, int sideC, double expected)
        {
            var _figure = new Triangle(sideA, sideB, sideC);
            Assert.Equal(expected: expected, _figure.GetArea());
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void IsTriangleRight_ShouldReturnTrue_WhenValuesSuitable(int sideA, int sideB, int sideC)
        {
            var _figure = new Triangle(sideA, sideB, sideC);
            Assert.True(_figure.Type==FigureLibrary.Enums.TriangleType.Right);
        }

        [Theory]
        [InlineData(4, 5, 6)]
        [InlineData(4.5, 5.6, 6.4)]
        [InlineData(9, 10, 15)]
        public void IsTriangleRight_ShouldReturnFalse_WhenValuesNotSuitable(int sideA, int sideB, int sideC)
        {
            var _figure = new Triangle(sideA, sideB, sideC);
            Assert.False(_figure.Type == FigureLibrary.Enums.TriangleType.Right);
        }

        [Theory]
        [InlineData(3, 4, 5, 5, 2)]
        public void TriangleSize_ShouldEqualsData_WhenValuesSuitable(int sideA, int sideB, int sideC,int expectedWidth, int expectedHeight)
        {
            var _figure = new Triangle(sideA, sideB, sideC);
            Assert.Equal(expected: expectedWidth, _figure.Size.Width);
            Assert.Equal(expected: expectedHeight, _figure.Size.Height);
        }
    }
}