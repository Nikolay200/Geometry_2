using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_2_WindowsFormsApp
{
    public abstract class Figure
    {
        public abstract double Perimeter();
        public abstract double Square();
    }
    public class Circle : Figure
    {
        public const double Pi = 3.14;
        public double Side { get; set; }
        public Circle(double side)
        {
            Side = side;
        }
        public override double Perimeter()
        {
            return 2 * Pi * Side;
        }
        public override double Square()
        {
            return Pi * Side * Side;
        }        
    }
    public class Rectangle : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public override double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }
        public override double Square()
        {
            return Side1 * Side2;
        }        
    }

    public class Triangle : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
        public override double Square()
        {
            var halfPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));
        }        
    }
}
