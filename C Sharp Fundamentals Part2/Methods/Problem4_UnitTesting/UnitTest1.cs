using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4_CountNumber;

namespace Problem4_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = CountNumber.NumberSearch(3, new int[] { 1,2,3,4,5 });
            string value = "1";
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string result = CountNumber.NumberSearch(3, new int[] { 1, 3, 3, 3, 5 });
            string value = "3";
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string result = CountNumber.NumberSearch(10, new int[] { 1, 2, 3, 4, 5 });
            string value = "Number 10 does not appear in the array!";
            Assert.AreEqual(value, result);
        }
    }
}
