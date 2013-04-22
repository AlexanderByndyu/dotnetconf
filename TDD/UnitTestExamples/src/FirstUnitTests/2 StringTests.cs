// ReSharper disable InconsistentNaming

namespace _01CreateUnitTest
{
    using NUnit.Framework;

    public class StringTests
    {
        [Test]
        public void StringComparingCaseSensitive()
        {
            bool result = "some string" == "some String";

            Assert.False(result);
        }
    }
}