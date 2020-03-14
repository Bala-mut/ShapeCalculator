using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model.Triangle
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double side) : base(side, side, side)
        {
            this.name = "Равносторонний треугольник";
        }

        public override double GetPerimeter()
        {
            return firstSide * 3;
        }

        public override double GetSquare()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(firstSide, 2);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(this.name);
            stringBuilder.AppendFormat("\nСторона: {0}", firstSide);
            stringBuilder.AppendFormat("\nПериметр: {0}", GetPerimeter());
            stringBuilder.AppendFormat("\nПлощадь: {0}", GetSquare());
            return stringBuilder.ToString();
        }
    }
}
