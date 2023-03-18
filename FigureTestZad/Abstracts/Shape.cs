using FigureLib.Abstracts.Interfaces;
using System;

namespace FigureLib.Abstracts
{
    public abstract class Shape : IFigure
    {
        public double Radius { get; }

        protected Shape(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не должен быть меньше нуля!");
            Radius = radius;
        }

        public abstract double GetArea();
    }
}