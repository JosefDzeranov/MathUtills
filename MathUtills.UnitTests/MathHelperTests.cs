using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathUtills;
using System.Diagnostics.CodeAnalysis;

namespace MathUtills.UnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class MathHelperTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetRightTriangleSquare_TriangleNotExist_ThrowException_Test()
        {
            double a = 1;
            double b = 3;
            double c = 4;

            MathHelper.GetRightTriangleSquare(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetRightTriangleSquare_TriangleNotRight_ThrowException_Test()
        {
            double a = 2;
            double b = 5;
            double c = 6;

            MathHelper.GetRightTriangleSquare(a, b, c);
        }
        
        [TestMethod]
        public void GetRightTriangleSquare_GetTriangleSquareFirstCase_ThrowException_Test()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            var actual = MathHelper.GetRightTriangleSquare(a, b, c);

            Assert.AreEqual(6, actual,"Invalid square.");
        }

        [TestMethod]
        public void GetRightTriangleSquare_GetTriangleSquareSecondCase_ThrowException_Test()
        {
            double a = 3;
            double b = 5;
            double c = 4;

            var actual = MathHelper.GetRightTriangleSquare(a, b, c);

            Assert.AreEqual(6, actual, "Invalid square.");
        }
       
        [TestMethod]
        public void GetRightTriangleSquare_GetTriangleSquareThirdCase_ThrowException_Test()
        {
            double a = 5;
            double b = 3;
            double c = 4;

            var actual = MathHelper.GetRightTriangleSquare(a, b, c);

            Assert.AreEqual(6, actual, "Invalid square.");
        }
    }
}
