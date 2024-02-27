using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaFigureLibrary
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0) throw new InvalidOperationException("The radius of the circle is set incorrectly.");
            this.radius = radius;
        }

        public double GetArea()
        {
            if (radius < 0) throw new InvalidOperationException("The radius of the circle is set incorrectly.");
            return Math.PI * radius * radius;
        }
    }
}
