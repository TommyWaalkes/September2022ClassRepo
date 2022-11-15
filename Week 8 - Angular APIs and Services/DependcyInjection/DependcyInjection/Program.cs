
using DependcyInjection;

//This allows for customization as well as delegation
ShapeCalculator s = new ShapeCalculator(new GetCircle());

double area = s.GetArea();

Console.WriteLine(area);
