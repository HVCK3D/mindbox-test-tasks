using FigureAreaCalculator.Figures.Interfaces;

namespace FigureAreaCalculator.Figures
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : IFigure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        private readonly double _area;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона В</param>
        /// <param name="sideC">Сторона С</param>
        /// <exception cref="ArgumentException">Возникает, если хоть одна из сторон меньше 0</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0)
            {
                throw new ArgumentException("Side A cannot be less than 0", nameof(sideA));
            }

            if (sideB < 0)
            {
                throw new ArgumentException("Side A cannot be less than 0", nameof(sideA));
            }

            if (sideB < 0)
            {
                throw new ArgumentException("Side A cannot be less than 0", nameof(sideA));
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            IsRightTriangle = CheckIsRight(sideA, sideB, sideC);

            _area = CalculateArea(sideA, sideB, sideC);
        }

        /// <summary>
        /// Флаг обозначающий прямоугольный треугольник
        /// </summary>
        public bool IsRightTriangle { get; }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        public double Area => _area;

        /// <summary>
        /// Метод определяет, является ли треугольник прямоугольным
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона В</param>
        /// <param name="sideC">Сторона С</param>
        /// <returns></returns>
        private bool CheckIsRight(double sideA, double sideB, double sideC)
        {
            var hipotenuse = Math.Max(sideA, Math.Max(sideB, sideC));

            var leg1 = 0.0;
            var leg2 = 0.0;

            if (hipotenuse == sideA)
            {
                leg1 = sideB;
                leg2 = sideC;
            }

            if (hipotenuse == sideB)
            {
                leg1 = sideA;
                leg2 = sideC;
            }

            if (hipotenuse == sideC)
            {
                leg1 = sideA;
                leg2 = sideB;
            }

            return Math.Abs((hipotenuse * hipotenuse) - ((leg1 * leg1) + (leg2 * leg2))) < double.Epsilon;
        }

        /// <summary>
        /// Метод возвращает площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона В</param>
        /// <param name="sideC">Сторона С</param>
        /// <returns></returns>
        private double CalculateArea(double sideA, double sideB, double sideC)
        {
            var perimeter = (sideA + sideB + sideC) / 2;

            return Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        }
    }
}
