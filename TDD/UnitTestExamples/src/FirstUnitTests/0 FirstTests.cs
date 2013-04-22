namespace _01CreateUnitTest
{
    using NUnit.Framework;

    public class FirstTests
    {
        [Test]
        public void FirstSuccessTest()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void FirstFailTest()
        {
            Assert.True(false);
        }
    }
}