using NUnit.Framework;
using System;
using Task1.Figures;

namespace Task1.Tests
{
    public class CircleTests
    {
        [TestCase(1, Math.PI)]
        [TestCase(2, 12.566370614359172)]
        [TestCase(34.56, 3752.298159254666)]
        public void CountArea_RadiusGreaterThanZero_ReturnsArea(double radius, double expected)
        {
            // given
            var circle = new Circle(radius);

            // when
            var actual = circle.CountArea();

            // then
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(radius, circle.Radius);
        }

        [TestCase(-42)]
        [TestCase(0)]
        public void RadiusIsLessThanZeroOrEqualsZero_ConstructorThrowsArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}