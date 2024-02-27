using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaFigureLibrary
{
    public class Triangle : IShape
    {
        private double sideA, sideB, sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Invalid triangle sides. The sum of the lengths of any two sides must be greater than the length of the third side.");
            }
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        private static bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public double GetArea()
        {
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new InvalidOperationException("Triangle with given sides does not exist.");
            }
            // ф. Герона
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public string IsRightAngled()
        {
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new InvalidOperationException("Triangle with given sides does not exist.");
            }
            // через т. Пифагора
            return sideA * sideA + sideB * sideB == sideC * sideC ||
                   sideA * sideA + sideC * sideC == sideB * sideB ||
                   sideB * sideB + sideC * sideC == sideA * sideA ? "Yes" : "No";
        }
    }
}
