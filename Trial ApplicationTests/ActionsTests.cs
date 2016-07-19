using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trial_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_Application.Tests
{
    [TestClass()]
    public class ActionsTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            var expected = "Hello";
            Assert.AreEqual(Actions.SayHello(), expected);
        }

        [TestMethod()]
        public void SayGoodbyeTest()
        {
            var expected = "Goodbye";
            Assert.AreEqual(Actions.SayGoodbye(), expected);
        }

        [TestMethod()]
        public void AdditionTest()
        {
            var expected = 2;
            Assert.AreEqual(Actions.Addition(), expected);
        }
    }
}