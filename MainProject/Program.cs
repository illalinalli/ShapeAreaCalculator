using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcAreaFigureLibrary;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(8);
            Console.WriteLine($"Area of the circle: {circle.GetArea()}");

            IShape triangle = new Triangle(5, 5, 5);
            Console.WriteLine($"Area of the triangle: {triangle.GetArea()}");

            if (triangle is Triangle triangleObj)
            {
                Console.WriteLine($"Is the triangle right-angled: {triangleObj.IsRightAngled()}");
            }
            Console.ReadKey();
        }
    }
}
