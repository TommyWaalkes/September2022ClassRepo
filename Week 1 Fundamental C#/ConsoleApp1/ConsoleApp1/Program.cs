// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input the Radius of a circle");

string input = Console.ReadLine();
double radius = double.Parse(input);

Console.WriteLine("Radius: "+ radius);
Console.WriteLine();

double area = Math.PI * radius * radius;

Console.WriteLine("Area: "+ area);