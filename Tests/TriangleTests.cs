using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figures.Tests
{
    [TestClass]
    public class TriangleTests
    {

        void TestTriangleArea(double SideA, double SideB, double SideC, double expectedResult)
        {
            double _result = Triangle.Area(SideA, SideB, SideC);

            Assert.AreEqual(expectedResult, _result);
        }

        void TestTriangleIsRectangular(double SideA, double SideB, double SideC, bool expectedResult)
        {
            bool _result = Triangle.IsRectangular(SideA, SideB, SideC);

            Assert.AreEqual(expectedResult, _result);
        }

        [TestMethod]
        public void OrdinaryTriangleArea()
        {
            TestTriangleArea(1, 2, 3, 0);
            TestTriangleArea(3, 4, 5, 6);
            TestTriangleArea(4, 10, 10, 19.595917942265423);
        }

        [TestMethod]
        public void NegativeArgsTriangleArea()
        {
            Assert.ThrowsException<ArgumentException>(() => Triangle.Area(-3, 1, 2));
            Assert.ThrowsException<ArgumentException>(() => Triangle.Area(3, -1, 2));
            Assert.ThrowsException<ArgumentException>(() => Triangle.Area(3, 1, -2));
            Assert.ThrowsException<ArgumentException>(() => Triangle.Area(0, 1, 2));
            Assert.ThrowsException<ArgumentException>(() => Triangle.Area(5, 0, 2));
            Assert.ThrowsException<ArgumentException>(() => Triangle.Area(-3, 1, 0));
        }

        [TestMethod]
        public void OrdinaryTriangleIsRectangular()
        {
            TestTriangleIsRectangular(1, 2, 3, true);
            TestTriangleIsRectangular(3, 4, 5, false);
            TestTriangleIsRectangular(1, 1, 1, false);
        }

        [TestMethod]
        public void NegativeArgsTriangleIsRectangular()
        {
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRectangular(-3, 1, 2));
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRectangular(4, -1, 7));
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRectangular(3, 6, -9));
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRectangular(0, 1, 2));
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRectangular(3, 0, 2));
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRectangular(3, 1, 0));
        }
    }
}
