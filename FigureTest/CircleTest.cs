using System;
using FigureLib.Figures;
using Xunit;

namespace FigureTest
{
    public class CircleTest
    {
        private const double Eps = 1E-5;

        [Fact]
        public void CreateCircleWithZeroRadiusTest()
        {
            Circle circle = new Circle(0);
            var area = circle.GetArea();
            Assert.Equal(0, area);
        }

        [Fact]
        public void CreateCircleWithLessZeroRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-10));
        }

        [Fact]
        public void CreateCircleWithMoreZeroRadiusTest()
        {
            Circle circle = new Circle(10);
            var area = circle.GetArea();
            Assert.True(Math.Abs(314.1592653589 - area) <= Eps);
        }
    }
}