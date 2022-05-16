using NUnit.Framework;
using System;
using Task1.Figures;

namespace Task1.Tests
{
    public class FigureAreaCalculatorTests
    {
        [TestCase(1, Math.PI)]
        [TestCase(2, 12.566370614359172)]
        public void CountArea_CircleShape_ReturnsCircleArea(double radius, double expected)
        {
            // given
            var circle = new Circle(radius);

            // when
            var actual = FigureAreaCalculator.CountArea(circle);

            // then
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(radius, circle.Radius);
        }

        [TestCase(1, 2, 3, 0)]
        [TestCase(9, 9, 9, 35.074028853269766)]
        public void CountArea_TriangleShape_ReturnsTriangleArea(double sideA, double sideB, double sideC, double expected)
        {
            // given
            var triangle = new Triangle(sideA, sideB, sideC);

            // when
            var actual = FigureAreaCalculator.CountArea(triangle);

            // then
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(sideA, triangle.SideA);
            Assert.AreEqual(sideB, triangle.SideB);
            Assert.AreEqual(sideC, triangle.SideC);
        }
    }
}
