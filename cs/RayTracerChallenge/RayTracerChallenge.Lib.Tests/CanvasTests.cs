using NUnit.Framework;
using System.Linq;

namespace RayTracerChallenge.Lib.Tests
{
    [TestFixture]
    public class CanvasTests
    {
        [Test]
        public void Ctor_PropertiesInitialized()
        {
            // Arrange
            // Act
            var canvas = new Canvas(10, 20);

            // Assert
            Assert.AreEqual(10, canvas.Width);
            Assert.AreEqual(20, canvas.Height);
            Assert.AreEqual(10 * 20, canvas.Pixels.Count());
            Assert.IsTrue(canvas.Pixels.All(x => x.Equals(new Color(0.0, 0.0, 0.0))));
        }

        [Test]
        public void WritePixel_Red_2_3_PixelAt_2_3_IsRed()
        {
            // Arrange 
            var canvas = new Canvas(10, 20);
            var red = new Color(255, 0, 0);

            // Act 
            canvas.WritePixel(2, 3, red);
            var pixel = canvas.PixelAt(2, 3);

            // Assert
            Assert.AreEqual(new Color(255, 0, 0), pixel);
        }

        [Test]
        public void ToPpm_CheckPpmDocumentIsCorrent()
        {
            // Arrange 
            var canvas = new Canvas(5, 3);

            // Act
            var ppm = canvas.ToPpm();

            // Assert
            var lines = ppm.Split("\r\n");
            Assert.AreEqual("P3", lines[0]);
            Assert.AreEqual("5 3", lines[1]);
            Assert.AreEqual("255", lines[2]);
        }

        [Test]
        public void ToPpm_CheckPixelConstruction()
        {
            // Arrange
            var canvas = new Canvas(5, 3);

            var c1 = new Color(1.5, 0, 0);
            var c2 = new Color(0, 0.5, 0);
            var c3 = new Color(-0.5, 0, 1);

            var red = "255 0 0";
            var darkGreen = "0 128 0";
            var blue = "0 0 255";
            var black = "0 0 0";

            // Act
            canvas.WritePixel(0, 0, c1);
            canvas.WritePixel(2, 1, c2);
            canvas.WritePixel(4, 2, c3);
            var ppm = canvas.ToPpm();

            // Assert
            var lines = ppm.ReadLines();

            Assert.AreEqual($"{red} {black} {black} {black} {black}", lines.ElementAt(3));
            Assert.AreEqual($"{black} {black} {darkGreen} {black} {black}", lines.ElementAt(4));
            Assert.AreEqual($"{black} {black} {black} {black} {blue}", lines.ElementAt(5));
        }
    }
}
