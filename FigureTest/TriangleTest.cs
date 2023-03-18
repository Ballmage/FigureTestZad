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
        public void Creeat()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, -6, 2));
        }
    
    }

    
}
