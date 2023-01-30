namespace MathLibrary
{
    public abstract class Figure
    {
        double area;

        public Figure(double _area)
        {
            area = _area;
        }

        public double GetArea() => area;
    }

    public class Circle: Figure
    {
        public Circle(double radius): base (Math.PI * Math.Pow(radius, 2))
        {
            if (radius < 0) throw new ArgumentException("Значение радиуса должно быть положительным");
        }
    }

    public class Triangle : Figure
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double _a, double _b, double _c) : 
            base(Math.Sqrt(
                ((_a + _b + _c) / 2) * (((_a + _b + _c) / 2) - _a) * (((_a + _b + _c) / 2) - _b) * (((_a + _b + _c)/2) - _c)
            ))
        {
            if (_a <= 0 || _b <= 0 || _c <= 0)
                throw new ArgumentException("Значене длин сторон треугольника должно быть положительным");

            a = _a;
            b = _b;
            c= _c;
        }

        public bool isRectangular() => Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
    }
}