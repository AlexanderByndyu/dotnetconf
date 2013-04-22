// ReSharper disable InconsistentNaming

namespace _01CreateUnitTest
{
    using System.Text.RegularExpressions;
    using NUnit.Framework;

    public class RegExTests
    {
        // TODO: Debug test
        [Test]
        public void IfStringContainsInt_ReturnAsMatchList()
        {
            MatchCollection matches = Regex.Matches("12 34 56", @"\d+");

            Assert.AreEqual(3, matches.Count);
            Assert.AreEqual("12", matches[0].Value);
            Assert.AreEqual("34", matches[1].Value);
            Assert.AreEqual("56", matches[2].Value);
        }
    }
}