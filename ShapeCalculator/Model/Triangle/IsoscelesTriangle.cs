using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model.Triangle
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double side, double baseSide) : base(side, side, baseSide)
        {
            this.name = "Равнобедренный треугольник";
        }

        public override double GetPerimeter()
        {
            return firstSide * 2 + thirdSide;
        }

        public override double GetSquare()
        {
            return (thirdSide * Math.Sqrt(Math.Pow(firstSide, 2) -
                Math.Pow(thirdSide, 2) / 4)) / 2;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(this.name);
            stringBuilder.AppendFormat("\nБоковая сторона: {0}", firstSide);
            stringBuilder.AppendFormat("\nОснование: {0}", thirdSide);
            stringBuilder.AppendFormat("\nПериметр: {0}", GetPerimeter());
            stringBuilder.AppendFormat("\nПлощадь: {0}", GetSquare());
            return stringBuilder.ToString();
        }
    }
}
