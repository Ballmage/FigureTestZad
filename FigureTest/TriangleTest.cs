using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FigureLib.Figures;

namespace FigureTest
{
    public class TriangleTest
    {
      

        private const double Eps = 1E-5;

        [Fact]
        public void CreeatTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, -6, 2));
        }
        [Fact]
        public void RightTriangleTest()
        {
            Triangle Triangle = new Triangle(3, 4, 5);
            Assert.True(Triangle.IsRightTriangle());
        }
    }

    
}
