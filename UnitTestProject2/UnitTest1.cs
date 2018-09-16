using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTestWebJustDotNet;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = MyTestWebJustDotNet._Default.getMeaningOfLife();
            if (result != 42)
            {
                Assert.Fail();
            }
        }
    }
}
