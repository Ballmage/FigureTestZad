using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLib.Abstracts.Interfaces;
using FigureLib.Figures;

namespace FigureApp
{
    class Class1
    {
        static void Main(string[] args)
        {

           

            IFigure circle = new Circle(6);
            var circleArea = circle.GetArea();
            Console.WriteLine(circleArea);

            Triangle triangle = new Triangle(3, 4, 5);
            var triangleArea = triangle.GetArea();
            Console.WriteLine(triangleArea);
            var isRight = triangle.IsRightTriangle();
            Console.WriteLine(isRight);
        }


    }
   
}
