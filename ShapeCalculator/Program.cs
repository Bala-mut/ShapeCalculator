using ShapeCalculator.Model;
using ShapeCalculator.Model.Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeBase[] shapes = new ShapeBase[4];
            shapes[0] = new Triangle(5, 6, 7);
            shapes[1] = new IsoscelesTriangle(5, 6);
            shapes[2] = new EquilateralTriangle(5);
            shapes[3] = new RectangularTriangle(3, 4);
            foreach (ShapeBase shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}