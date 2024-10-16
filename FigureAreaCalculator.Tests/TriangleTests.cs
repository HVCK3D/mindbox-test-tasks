using FigureAreaCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CreateTriangle_CorrectArea()
        {
            var expectedArea = 7.483;

            var a = 3;
            var b = 5;
            var c = 6;

            var triangle = new Triangle(a, b, c);
            var actualArea = triangle.Area;

            Assert.Equal(expectedArea, actualArea, 0.001);
        }

        [Fact]
        public void CreateTriangle_ShouldBeRight()
        {
            var a = 3;
            var b = 4;
            var c = 5;

            var triangle = new Triangle(a, b, c);
            var actualArea = triangle.Area;

            Assert.True(triangle.IsRightTriangle);
        }

        [Fact]
        public void CreateTriangle_NegativeSides_ThrowException()
        {
            var a = -3;
            var b = -4;
            var c = 5;

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void CreateTriangle_ZeroSides_ZeroArea()
        {
            var expectedArea = 0;

            var a = 0;
            var b = 0;
            var c = 0;

            var triangle = new Triangle(a, b, c);
            var actualArea = triangle.Area;

            Assert.Equal(expectedArea, actualArea, 0.001);
        }

        [Fact]
        public void CreateTriangle_ShouldNotBeRight()
        {
            var a = 1;
            var b = 9;
            var c = 6;

            var triangle = new Triangle(a, b, c);
            var actualArea = triangle.Area;

            Assert.False(triangle.IsRightTriangle);
        }
    }
}
