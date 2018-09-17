using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp
{
    [TestFixture]
    class Test
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [TestCase]
        public void Test1()
        {
        }

        [TestCase]
        public void Test2()
        {
            Assert.IsTrue(false);
        }
    }
}