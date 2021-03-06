﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void ConstructorTest_InvalidArgs()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2));
        }

        [TestMethod]
        public void Test_GetArea()
        {
            const double smallCathete = 3;
            const double bigCathete = 4;
            Assert.AreEqual(0.5 * smallCathete * bigCathete, new Triangle(smallCathete, bigCathete, 5).GetArea());
        }
    }
}
