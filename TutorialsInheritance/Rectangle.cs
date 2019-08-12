using System;

namespace TutorialsInheritance
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; }
        public double Width { get; }
        public override double Area => Length * Width;
        public override double Perimeter => (Length + Width) * 2;

        public bool IsSquare() => Length == Width;

        public double Diagonal => Math.Round(
            Math.Sqrt(
                Math.Pow(Length, 2) + Math.Pow(Width, 2)
            ),
            2
        );
    }
}