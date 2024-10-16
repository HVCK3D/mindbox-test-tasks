using FigureAreaCalculator.Infrastructure;

namespace FigureAreaCalculator
{
    /// <summary>
    /// Калькулятор площади
    /// </summary>
    public class AreaCalculator
    {
        //TODO возможно стоило бы сделать инъекцию фабрики через конструктор калькулятора
        private readonly FiguresFactory _figuresFactory = new FiguresFactory();

        /// <summary>
        /// Метод вычисления площади окружности
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns></returns>
        public double CalculateCircleArea(double radius)
        {
            var figure = _figuresFactory.CreateCircle(radius);
            return figure.Area;
        }

        /// <summary>
        /// Метод вычисления площади треугольника
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона В</param>
        /// <param name="sideC">Сторона С</param>
        /// <returns></returns>
        public double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            var figure = _figuresFactory.CreateTriangle(sideA, sideB, sideC);
            return figure.Area;
        }
    }
}
