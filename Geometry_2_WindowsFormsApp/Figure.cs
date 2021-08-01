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
        public double Radius;
        
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Perimeter()
        {
            return 2 * Pi * Radius;
        }
        public override double Square()
        {
            return Pi * Radius * Radius;
        }        
    }
    public class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double Perimeter()
        {
            return (Height + Width) * 2;
        }
        public override double Square()
        {
            return Height * Width;
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
            return Math.Sqrt(halfPerimeter * Math.Abs(halfPerimeter - Side1) * Math.Abs(halfPerimeter - Side2) * Math.Abs(halfPerimeter - Side3));
        }        
    }
}
