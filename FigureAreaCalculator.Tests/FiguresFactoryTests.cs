using FigureAreaCalculator.Figures;
using FigureAreaCalculator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Tests
{
    public class FiguresFactoryTests
    {
        private readonly FiguresFactory _figuresFactory;

        public FiguresFactoryTests()
        {
            _figuresFactory = new FiguresFactory();
        }

        [Fact]
        public void CreateCircle_IsCircle()
        {
            var figure = _figuresFactory.CreateCircle(5);

            Assert.IsType<Circle>(figure);
        }

        [Fact]
        public void CreateTriangle_IsTriangle()
        {
            var figure = _figuresFactory.CreateTriangle(4, 1, 6);

            Assert.IsType<Triangle>(figure);
        }
    }
}
