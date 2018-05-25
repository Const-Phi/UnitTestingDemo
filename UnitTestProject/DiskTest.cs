using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class DiskTest
    {
        [TestMethod]
        public void DiskConstuctor_ValidArgs()
        {
            const double radius = 10;
            Assert.AreEqual(radius, new Disk(radius).Radius);
        }

        [TestMethod]
        public void DiskConstuctor_Default()
        {
            const double radius = 0;
            Assert.AreEqual(radius, new Disk().Radius);
        }

        [TestMethod]
        public void DiskConstuctor_InvalidArgs()
        {
            const double radius = -10;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Disk(radius));
        }
    }
}
