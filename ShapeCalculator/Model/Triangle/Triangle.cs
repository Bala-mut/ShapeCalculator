using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model.Triangle
{
    class Triangle : ShapeBase
    {
        protected double firstSide;
        protected double secondSide;
        protected double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.name = "Треугольник";
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(this.name);
            stringBuilder.AppendFormat("\nПервая сторона: {0}", firstSide);
            stringBuilder.AppendFormat("\nВторая сторона: {0}", secondSide);
            stringBuilder.AppendFormat("\nТретья сторона: {0}", thirdSide);
            stringBuilder.AppendFormat("\nПериметр: {0}", GetPerimeter());
            stringBuilder.AppendFormat("\nПлощадь: {0}", GetSquare());
            return stringBuilder.ToString();
        }

        public override double GetPerimeter()
        {
            return firstSide + secondSide + thirdSide;
        }

        public override double GetSquare()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide)
                * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        }
    }
}
