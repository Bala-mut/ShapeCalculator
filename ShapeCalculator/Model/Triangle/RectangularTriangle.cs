using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model.Triangle
{
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double firstCathet, double secondCathet)
            : base(firstCathet, secondCathet,
                  Math.Sqrt(Math.Pow(firstCathet, 2) + Math.Pow(secondCathet, 2)))
        {
            name = "Прямоугольный треугольник";
        }

        public override double GetSquare()
        {
            return firstSide * secondSide / 2;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(this.name);
            stringBuilder.AppendFormat("\nПервый катет: {0}", firstSide);
            stringBuilder.AppendFormat("\nВторой катет: {0}", secondSide);
            stringBuilder.AppendFormat("\nГипотенузаа: {0}", thirdSide);
            stringBuilder.AppendFormat("\nПериметр: {0}", GetPerimeter());
            stringBuilder.AppendFormat("\nПлощадь: {0}", GetSquare());
            return stringBuilder.ToString();
        }
    }
}
