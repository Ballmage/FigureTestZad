using FigureLib.Abstracts.Interfaces;
using System;
using System.Linq;

namespace FigureLib.Abstracts
{
   
    public abstract class Polygon : IFigure
    {
        static void Main(string[] args)
        { }
        public double[] Sides { get; }

        protected Polygon(double[] sides)
        {
            foreach (var size in sides)
            {
                if (size < 0)
                    throw new ArgumentException("Каждая сторона не должна быть меньше нуля");
            }
            Sides = sides;
        }

        public abstract double GetArea();
        public double GetPerimeter() => Sides.Sum();
    }
}