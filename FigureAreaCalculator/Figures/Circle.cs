using FigureAreaCalculator.Figures.Interfaces;

namespace FigureAreaCalculator.Figures
{

    /// <summary>
    /// Класс окружности
    /// </summary>
    public class Circle : IFigure
    {
        private readonly double _radius;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentException">Возникает, если радиус меньше 0</exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius cannot be less than zero", nameof(radius));
            }
            _radius = radius;
        }

        /// <summary>
        /// Площадь окружности
        /// </summary>
        public double Area => Math.PI * _radius * _radius;
    }
}
