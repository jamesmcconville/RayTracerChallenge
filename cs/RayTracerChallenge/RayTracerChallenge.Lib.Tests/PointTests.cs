using NUnit.Framework;

namespace RayTracerChallenge.Lib.Tests
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void Ctor_PropertiesInitialized()
        {
            // Arrange 
            // Act
            var point = new Point(4, -4, 3);

            // Assert
            Assert.AreEqual(4.0, point.X);
            Assert.AreEqual(-4.0, point.Y);
            Assert.AreEqual(3.0, point.Z);
            Assert.AreEqual(1.0, point.W);
        }

        [Test]
        public void SubtractPointFromPoint_ReturnsNewVector()
        {
            // Arrange 
            var point1 = new Point(3, 2, 1);
            var point2 = new Point(5, 6, 7);

            // Act
            var result = point1 - point2;

            // Assert
            Assert.AreEqual(new Vector(-2, -4, -6), result);
        }

        [Test]
        public void SubtractVectorFromPoint_ReturnsNewVector()
        {
            // Arrange 
            var point = new Point(3, 2, 1);
            var vector = new Vector(5, 6, 7);

            // Act
            var result = point - vector;

            // Assert
            Assert.AreEqual(new Point(-2, -4, -6), result);
        }
    }
}
