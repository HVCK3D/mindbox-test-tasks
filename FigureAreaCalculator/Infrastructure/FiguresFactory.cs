using FigureAreaCalculator.Figures;
using FigureAreaCalculator.Figures.Interfaces;

namespace FigureAreaCalculator.Infrastructure
{
    /// <summary>
    /// Класс фабрики создания фигур
    /// </summary>
    public class FiguresFactory
    {
        /// <summary>
        /// Метод создания окружности
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns></returns>
        public IFigure CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Метод создания треугольника
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона В</param>
        /// <param name="sideC">Сторона С</param>
        /// <returns></returns>
        public IFigure CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        } 

    }
}
