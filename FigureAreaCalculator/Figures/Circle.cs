namespace Task1.Figures
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            ExceptionHelper.CheckIfRadiusIsValid(radius);
            Radius = radius;
        }

        public override double CountArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
