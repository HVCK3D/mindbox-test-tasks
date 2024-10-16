using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Tests
{
    public class AreaCalculatorTests
    {
        private readonly AreaCalculator _areaCalculator;

        public AreaCalculatorTests()
        {
            _areaCalculator = new AreaCalculator();
        }

        [Fact]
        public void CalculateCircleArea_CorrectArea()
        {
            var expectedArea = 314.159;

            var radius = 10;
            var actualArea = _areaCalculator.CalculateCircleArea(radius);

            Assert.Equal(expectedArea, actualArea, 0.001);
        }

        [Fact]
        public void CalculateTriangleArea_CorrectArea()
        {
            var expectedArea = 7.483;

            var a = 3;
            var b = 5;
            var c = 6;
            var actualArea = _areaCalculator.CalculateTriangleArea(a, b, c);

            Assert.Equal(expectedArea, actualArea, 0.001);
        }
    }
}
