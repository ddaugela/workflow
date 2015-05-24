using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Workflow.Core.Tests
{
    [TestClass]
    public class SimpleTest
    {
        [TestMethod]
        public void TestMath()
        {
            // assemble
            var one = 1;

            // act
            var two = one + one;

            // assert
            Assert.AreEqual(2, two);
        }
    }
}
