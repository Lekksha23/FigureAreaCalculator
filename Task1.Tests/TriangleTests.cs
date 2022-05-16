using NUnit.Framework;
using System;
using Task1.Figures;

namespace Task1.Tests
{
    public class TriangleTests
    {
        [TestCase(1, 2, 3, 0)]
        [TestCase(9, 9, 9, 35.074028853269766)]
        [TestCase(3.5, 7.5, 4.7, 6.1357655390342245)]
        [TestCase(369, 879, 786, 144941.75398414358)]
        public void CountArea_ValuesOfSidesAreValid_ReturnsArea(double sideA, double sideB, double sideC, double expected)
        {
            // given
            var triangle = new Triangle(sideA, sideB, sideC);

            // when
            var actual = triangle.CountArea();

            // then
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(sideA, triangle.SideA);
            Assert.AreEqual(sideB, triangle.SideB);
            Assert.AreEqual(sideC, triangle.SideC);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(5, 4, 3, true)]
        [TestCase(3, 5, 4, true)]
        [TestCase(3, 7, 5, false)]
        [TestCase(7, 3, 5, false)]
        [TestCase(5, 3, 7, false)]
        public void CheckIfTriangleIsRectangular_ReturnsTrueOrFalse(double sideA, double sideB, double sideC, bool expected)
        {
            // given
            var triangle = new Triangle(sideA, sideB, sideC);

            // when
            var actual = triangle.CheckIfTriangleIsRectangular();

            // then
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(sideA, triangle.SideA);
            Assert.AreEqual(sideB, triangle.SideB);
            Assert.AreEqual(sideC, triangle.SideC);
        }

        [TestCase(0, 0, 0)]
        [TestCase(-42, 23, 56)]
        [TestCase(42, -23, 56)]
        [TestCase(42, 23, -56)]
        [TestCase(369, 879600, 786500)]
        public void ValuesOfSidesAreInvalid_ConstructorThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}
