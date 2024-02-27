using CalcAreaFigureLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Circle_GetArea1()
        {
            Circle circle = new Circle(5);
            double expected = Math.PI * 25;
            double actual = circle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Circle_GetArea2()
        {
            Circle circle = new Circle(0);
            double expected = Math.PI * 0;
            double actual = circle.GetArea();
            Assert.AreEqual(expected, actual, "Method GetArea in Circle.cs isn't correct.");
        }

        [TestMethod]
        public void Triangle_GetArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;
            double actual = triangle.GetArea();
            Assert.AreEqual(expected, actual, "Method GetArea in Circle.cs isn't correct.");
        }

        [TestMethod]
        public void Triangle_IsRightAngled()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            string expected = "Yes";
            string actual = triangle.IsRightAngled();
            Assert.AreEqual(expected, actual, "IsRightAngled in Triangle.cs isn't correct.");
        }

        [TestMethod]
        public void Triangle_NotRightAngled()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            string expected = "No";
            string actual = triangle.IsRightAngled();
            Assert.AreEqual(expected, actual, "IsRightAngled isn't correct.");
        }

        [TestMethod]
        public void Triangle_GetArea_InvalidTriangleSides()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 3));
        }

        [TestMethod]
        public void Circle_GetArea_InvalidRadius()
        {
            Assert.ThrowsException<InvalidOperationException>(() => new Circle(-4));
        }
    }
}
