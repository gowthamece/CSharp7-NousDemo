using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NousDemo;

namespace NousUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program _AddTest = new Program();
            var result = _AddTest.AddTest(10, 20);
            Assert.IsTrue(result == 30);

        }
    }
}
