using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model
{
    abstract class ShapeBase
    {
        protected string name;

        public abstract double GetPerimeter();

        public abstract double GetSquare();


    }
}
