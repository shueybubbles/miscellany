using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert=NUnit.Framework.Assert;

namespace NUnitWorkaround
{
    /// <summary>
    /// If you run all the tests in this class, TestMethod2 will fail with 2 messages instead of 1.
    ///  Message: Test method NUnitWorkaround.ExhibitTheIssue.TestMethod2 threw exception: 
    ///  NUnit.Framework.AssertionException: Multiple failures or warnings in test:
    ///  1) This is TestMethod1
    ///  2) This is TestMethod2
    /// </summary>
    [TestClass]
    public class ExhibitTheIssue
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Fail("This is TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("This is TestMethod2");
        }
    }
}
