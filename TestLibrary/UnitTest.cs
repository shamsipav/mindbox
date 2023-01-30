using MathLibrary;

namespace TestLibrary
{
    public class UnitTest
    {
        [Fact]
        public void TestCircleCorrectArea()
        {
            Circle circle = new(10);
            Assert.Equal(314.1592653589793, circle.GetArea());
        }

        [Fact]
        public void TestTriangleCorrectArea()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.Equal(6, triangle.GetArea());
        }

        [Fact]
        public void TestTriangleIsRectangular()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.True(triangle.isRectangular());
        }

        [Fact]
        public void TestTriangleIsNotRectangular()
        {
            Triangle triangle = new(3, 4, 6);
            Assert.False(triangle.isRectangular());
        }
    }
}