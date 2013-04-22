namespace _01CreateUnitTest
{
    using NUnit.Framework;

    // ReSharper disable InconsistentNaming
    public class IntTests
    {
        [Test]
        public void ParseCorrectString_ReturnInt()
        {
            int result = int.Parse("56");

            Assert.AreEqual(56, result);
        }
    }
}