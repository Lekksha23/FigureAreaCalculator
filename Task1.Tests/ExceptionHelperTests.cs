using NUnit.Framework;
using System;

namespace Task1.Tests
{
    public class ExceptionHelperTests
    {
        [TestCase(30, 40, 60)]
        public void CheckIfValuesIsValid_ValidValues_NoExceptionOccures(double sideA, double sideB, double sideC)
        {
            ExceptionHelper.CheckIfValuesIsValid(sideA, sideB, sideC);
            Assert.Pass();
        }

        [TestCase(23, 23, -23)]
        [TestCase(23, -23, 23)]
        [TestCase(-23, 23, 23)]
        [TestCase(30, 40, 80)]
        [TestCase(80, 40, 30)]
        [TestCase(40, 80, 30)]
        public void CheckIfValuesIsValid_InvalidValues_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => ExceptionHelper.CheckIfValuesIsValid(sideA, sideB, sideC));
        }

        [TestCase(23)]
        public void CheckIfRadiusIsValid_ValidRadius_NoExceptionOccures(double radius)
        {
            ExceptionHelper.CheckIfRadiusIsValid(radius);
            Assert.Pass();
        }

        [TestCase(-23)]
        public void CheckIfRadiusIsValid_InvalidRadius_ThrowsArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => ExceptionHelper.CheckIfRadiusIsValid(radius));
        }
    }
}
