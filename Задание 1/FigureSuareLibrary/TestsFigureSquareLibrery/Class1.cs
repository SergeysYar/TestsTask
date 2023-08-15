using System;
using NUnit.Framework;
using FigureSuareLibrary;

namespace TestsFigureSquareLibrery
{
    public class TestsSquare
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.AreEqual(expectedArea, circle.CalculateArea(), 0.001);
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 0.001);
        }

        [Test]
        public void RightAngledTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Triangle nonRightTriangle = new Triangle(3, 4, 6);

            Assert.IsTrue(rightTriangle.IsRightAngled());
            Assert.IsFalse(nonRightTriangle.IsRightAngled());
        }
    }
}
