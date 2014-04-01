using System;
using NUnit.Framework;

namespace MvcMoviesTests
{
    [TestFixture]
    public class SampleTest
    {
        [Test]
        public void Hello()
        {
            string testString = "hello";

            StringAssert.AreEqualIgnoringCase(testString, "HELLO");
        }

        [Test]
        public void Math()
        {
            Assert.AreEqual(3 + 4, 7);
        }
    }
}
