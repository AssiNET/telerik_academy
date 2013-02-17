using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1_AskUserForName;

namespace Problem1_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool isValid = AskUserForName.ValidateName("");
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool isValid = AskUserForName.ValidateName("123");
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool isValid = AskUserForName.ValidateName("Krasimir123");
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool isValid = AskUserForName.ValidateName("123Krasimir");
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void TestMethod5()
        {
            bool isValid = AskUserForName.ValidateName("K");
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void TestMethod6()
        {
            bool isValid = AskUserForName.ValidateName("Krasimir");
            Assert.AreEqual(true, isValid);
        }
    }
}
