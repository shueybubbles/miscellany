using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using Assert=NUnit.Framework.Assert;

namespace NUnitWorkaround
{
    /// <summary>
    /// By creating an IsolationContext for each test we bypass message accumulation.
    /// Run all the tests in this class, each will have a single failure message.
    ///   Message: Test method NUnitWorkaround.WorkAroundTheIssue.TestMethod2 threw exception: 
    ///   NUnit.Framework.AssertionException: This is TestMethod2
    /// </summary>
    [TestClass]
    public class WorkAroundTheIssue
    {
        private IDisposable nunitContext;

        [TestInitialize]
        public void MyInitialize()
        {
            nunitContext = new TestExecutionContext.IsolatedContext();
        }

        [TestCleanup]
        public void MyCleanup()
        {
            nunitContext?.Dispose();
        }

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
