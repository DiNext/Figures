using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figures.Tests
{
    [TestClass]
    public class CircleTests
    {

        void TestCircleArea(double radius, double expectedResult)
        {
            double _result = Circle.Area(radius);

            Assert.AreEqual(expectedResult, _result);
        }

        [TestMethod]
        public void OrdinaryCircleArea()
        {
            TestCircleArea(1, Math.PI);
            TestCircleArea(2, 12.566370614359172);
            TestCircleArea(25, 1963.4954084936207);
        }

        [TestMethod]
        public void NegativeRadius()
        {
            Assert.ThrowsException<ArgumentException>(() => Circle.Area(-3));
            Assert.ThrowsException<ArgumentException>(() => Circle.Area(0));
        }
    }
}
