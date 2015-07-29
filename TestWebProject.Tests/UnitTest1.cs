using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWebProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldNotBeEqual()
        {
            var a = 1;
            var b = 1;
            Assert.AreNotEqual(a, b);
        }
    }
}
