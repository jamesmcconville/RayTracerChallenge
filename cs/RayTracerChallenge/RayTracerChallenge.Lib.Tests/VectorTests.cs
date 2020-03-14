﻿using NUnit.Framework;
using System;

namespace RayTracerChallenge.Lib.Tests
{
    [TestFixture]
    class VectorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void NewVector_CreatesTupleWithW0()
        {
            // Arrange 
            var vector = new Vector(4, -4, 3);

            // Act
            // Assert
            Assert.AreEqual(0.0, vector.W);
        }

        [Test]
        public void AddTwoVectors_ReturnsNewVector()
        {
            // Arrange 
            var vector1 = new Vector(3, -2, 5);
            var vector2 = new Vector(-2, 3, 1);

            // Act
            var result = vector1 + vector2;

            // Assert
            Assert.AreEqual(new Vector(1,1,6), result);
        }

        [Test]
        public void AddVectorToPoint_ReturnsNewPoint()
        {
            // Arrange 
            var vector = new Vector(3, -2, 5);
            var point = new Point(-2, 3, 1);

            // Act
            var result = vector + point;

            // Assert
            Assert.AreEqual(new Point(1, 1, 6), result);
        }

        [Test]
        public void SubtractVectorFromVector_ReturnsNewVector()
        {
            // Arrange 
            var vector1 = new Vector(3, 2, 1);
            var vector2 = new Vector(5, 6, 7);

            // Act
            var result = vector1 - vector2;

            // Assert
            Assert.AreEqual(new Vector(-2, -4, -6), result);
        }

        [Test]
        public void SubtractVectorFromZeroVector_ReturnsNewVector()
        {
            // Arrange 
            var vector = new Vector(1, -2, 3);

            // Act
            var result1 = Vector.Zero() - vector;
            var result2 = -vector;

            // Assert
            Assert.AreEqual(new Vector(-1, 2, -3), result1);
            Assert.AreEqual(new Vector(-1, 2, -3), result2);
        }

        [Test]
        public void MultiplyVectorByScalar_ReturnsNewVector()
        {
            // Arrange 
            var vector = new Vector(1, -2, 3);

            // Act
            var result = vector * 3.5;

            // Assert 
            Assert.AreEqual(new Vector(3.5, -7, 10.5), result);
        }

        [Test]
        public void MultiplyVectorByFraction_ReturnsNewVector()
        {
            // Arrange 
            var vector = new Vector(1, -2, 3);

            // Act
            var result = vector * 0.5;

            // Assert 
            Assert.AreEqual(new Vector(0.5, -1, 1.5), result);
        }

        [Test]
        public void DivideVectorByScalar_ReturnsNewVector()
        {
            // Arrange 
            var vector = new Vector(1, -2, 3);

            // Act
            var result = vector / 2;

            // Assert 
            Assert.AreEqual(new Vector(0.5, -1, 1.5), result);
        }

        [TestCase(1, 0, 0, 1, false)]
        [TestCase(0, 1, 0, 1, false)]
        [TestCase(0, 0, 1, 1, false)]
        [TestCase(1, 2, 3, 14, true)]
        [TestCase(-1, -2, -3, 14, true)]
        public void NewVector_QueryMagnitude_MagnitudeIsCorrect(double x, double y, double z, double expectedMagnitude, bool applySquareRoot)
        {
            // Arrange 
            expectedMagnitude = applySquareRoot ? Math.Sqrt(expectedMagnitude) : expectedMagnitude;

            // Act
            var vector = new Vector(x, y, z);

            // Assert 
            Assert.AreEqual(expectedMagnitude, vector.Magnitude());
        }

        [TestCase(4, 0, 0, 1, 0, 0)]
        [TestCase(1, 2, 3, 0.26726, 0.53452, 0.80178)]
        public void NewVector_Normalize_MagnitudeIsCorrect(double x, double y, double z, double normX, double normY, double normZ)
        {
            // Arrange 
            var vector = new Vector(x, y, z);
            var expected = new Vector(normX, normY, normZ);

            // Act
            var normalized = vector.Normalize();

            // Assert 
            Assert.AreEqual(expected, normalized);
        }

        [Test]
        public void GetDotProductOfTwoVectors_ReturnsDotProduct()
        {
            // Arrange
            var vector1 = new Vector(1, 2, 3);
            var vector2 = new Vector(2, 3, 4);

            // Act
            var dot = vector1.Dot(vector2);

            // Assert
            Assert.AreEqual(20.0, dot);
        }
    }
}
