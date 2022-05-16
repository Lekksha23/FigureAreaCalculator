namespace Task1.Figures
{
    public class Triangle : Shape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            ExceptionHelper.CheckIfValuesIsValid(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CountArea()
        {
            var semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool CheckIfTriangleIsRectangular()
        {
            var sideAInSquare = Math.Pow(SideA, 2);
            var sideBInSquare = Math.Pow(SideB, 2);
            var sideCInSquare = Math.Pow(SideC, 2);

            if (SideA > SideB && SideA > SideC)
            {
                if (sideAInSquare == sideBInSquare + sideCInSquare) return true;
            }
            else if (SideB > SideC && SideB > SideA)
            {
                if (sideBInSquare == sideAInSquare + sideCInSquare) return true;
            }
            else if (SideC > SideA && SideC > SideB)
            {
                if (sideCInSquare == sideAInSquare + sideBInSquare) return true;
            }
            return false;
        }
    }
}
