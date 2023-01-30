using MathLibrary;

Circle circle = new(10);

Console.WriteLine(circle.GetArea());

Triangle triangle = new(3, 4, 5);

Console.WriteLine(triangle.GetArea());
Console.WriteLine(triangle.isRectangular());

Console.ReadKey();
