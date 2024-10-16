using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CreateCircle_CorrectArea()
        {
            var expectedArea = 314.159;

            var radius = 10;
            var circle = new Circle(radius);
            var actualArea = circle.Area;

            Assert.Equal(expectedArea, actualArea, 0.001);
        }

        [Fact]
        public void CreateCircle_NegativeRadius_ThrowException()
        {
            var radius = -10;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void CreateCircle_ZeroRadius_ZeroArea()
        {
            var expectedArea = 0;

            var radius = 0;
            var circle = new Circle(radius);
            var actualArea = circle.Area;

            Assert.Equal(expectedArea, actualArea, 0.001);
        }
    }
}