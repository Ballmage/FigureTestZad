using FigureLib.Abstracts;
using System;
using System.Linq;

namespace FigureLib.Figures
{
    public class Triangle : Polygon
    {
        public Triangle(double size1, double size2, double size3) : base(new[] { size1, size2, size3 })
        {
            if (size1 + size2 > size3 && size2 + size3 > size1 && size1 + size3 > size2) { }
            else
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует");
            }
                
        }

        public override double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        public bool IsRightTriangle(double eps = 1E-5)
        {
           
    
            double maxside = Sides.Max();
            maxside *= maxside;
            return maxside + maxside == Sides[0] * Sides[0] + Sides[1] * Sides[1] + Sides[2] * Sides[2];
        }
    }
}