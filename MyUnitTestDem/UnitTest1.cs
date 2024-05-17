using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyClassLibraryDem;

namespace MyUnitTestDem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expRes = 0;
            int actRes = SumClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes);
        }
    }
}
