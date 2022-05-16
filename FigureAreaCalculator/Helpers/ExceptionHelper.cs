namespace Task1
{
    public static class ExceptionHelper
    {
        public static void CheckIfValuesIsValid(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
            {
                throw new ArgumentException("Value of the A side must be greater than 0");
            }
            else if (sideB <= 0)
            {
                throw new ArgumentException("Value of the B side must be greater than 0");
            }
            else if (sideC <= 0)
            {
                throw new ArgumentException("Value of the C side must be greater than 0");
            }
            else if (sideA > (sideB + sideC))
            {
                throw new ArgumentException("Side A of a triangle is greater than the sum of the other two sides. Such a triangle cannot exist.");
            }
            else if (sideB > (sideC + sideA))
            {
                throw new ArgumentException("Side B of a triangle is greater than the sum of the other two sides. Such a triangle cannot exist.");
            }
            else if (sideC > (sideA + sideB))
            {
                throw new ArgumentException("Side C of a triangle is greater than the sum of the other two sides. Such a triangle cannot exist.");
            }
        }

        public static void CheckIfRadiusIsValid(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius value must be greater than 0");
            }
        }
    }
}
