namespace ShapeAreaCalculator
{
    public class ShapeCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double a, double b, double c)
        {
            // формула Герона
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static bool IsRightAngledTriangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);

            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}