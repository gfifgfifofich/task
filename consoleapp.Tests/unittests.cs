using Xunit;
using ConsoleApp;

namespace consoleapp.UnitTests
{
    public class Tests
    {
        [Theory]
        [InlineData(-1.0f)]
        [InlineData(0.0f)]
        [InlineData(1.0f)]
        public void CircleTest(float radius)
        {
            Circle c = new Circle(radius);
            Assert.True(c.GetArea()>=0.0f, $"{radius} returns negative area");
            Assert.True(c.R>=0.0f, $"{radius} negative radius");
        }
        [Theory]
        [InlineData(-1.0f,0.0f,2.0f)]
        [InlineData(3.0f,4.0f,5.0f)]
        [InlineData(2.0f,2.0f,2.0f)]
        public void TriangleAreaTest(float a, float b, float c )
        {
            Triangle t = new Triangle(a,b,c);
            Assert.False(t.Side1<0.0f ||t.Side2<0.0f || t.Side3<0.0f, $"triangle({a},{b},{c}) Has negative length side");

            Assert.False(t.GetArea()<0.0f, $"triangle({a},{b},{c}) returns negative area");
        }

        [Fact]
        public void TriangleRectTest()
        {
            Triangle t = new Triangle(3.0f,4.0f,5.0f);
            Assert.True(t.IsRectangular(), $" Triangle(3.0f,4.0f,5.0f) should be rectangular, but it's not");
        }
    }

}