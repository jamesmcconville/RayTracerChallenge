using NUnit.Framework;

namespace RayTracerChallenge.Lib.Tests
{
    [TestFixture]
    public class ColorTests
    {
        [Test]
        public void Add_ColorToColor_ReturnColor()
        {
            // Arrange
            var c1 = new Color(0.9, 0.6, 0.75);
            var c2 = new Color(0.7, 0.1, 0.25);

            // Act
            var result = c1 + c2;

            // Assert
            Assert.AreEqual(new Color(1.6, 0.7, 1.0), result);
        }

        [Test]
        public void Subtract_ColorFromColor_ReturnColor()
        {
            // Arrange
            var c1 = new Color(0.9, 0.6, 0.75);
            var c2 = new Color(0.7, 0.1, 0.25);

            // Act
            var result = c1 - c2;

            // Assert
            Assert.AreEqual(new Color(0.2, 0.5, 0.5), result);
        }

        [Test]
        public void Multiply_ColorWithColor_ReturnColor()
        {
            // Arrange
            var c1 = new Color(1, 0.2, 0.4);
            var c2 = new Color(0.9, 1, 0.1);

            // Act
            var result = c1 * c2;

            // Assert
            Assert.AreEqual(new Color(0.9, 0.2, 0.04), result);
        }

        [Test]
        public void Multiply_ColorWithScalar_ReturnColor()
        {
            // Arrange
            var c = new Color(0.2, 0.3, 0.4);

            // Act
            var result = c * 2;

            // Assert
            Assert.AreEqual(new Color(0.4, 0.6, 0.8), result);
        }
    }
}
