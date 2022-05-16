using Task1;
using Task1.Figures;

var circle = new Circle(4);
var circleArea = FigureAreaCalculator.CountArea(circle);

var triangle = new Triangle(3, 4, 5);
var triangleArea = FigureAreaCalculator.CountArea(triangle);

Console.WriteLine($"Площадь круга равна {circleArea}");
Console.WriteLine($"Площадь треугольника равна {triangleArea}");
