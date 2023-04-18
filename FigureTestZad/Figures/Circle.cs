using FigureLib.Abstracts;
using System;

namespace FigureLib.Figures
{
    public class Circle : Shape
    {
        public Circle(double radius) : base(radius)
        {
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}