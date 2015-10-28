using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTrainingGround.Tests
{
    [TestFixture]
    public class SimpleParserTests
    {
        private SimpleParser MakeParser()
        {
            return new SimpleParser();
        }

        public void ParseAndSum_EmptyParameter_Throws()
        {
            var parser = MakeParser();

            var ex = Assert.Catch<ArgumentNullException>(() => parser.ParseAndSum(null));

            StringAssert.Contains("argument needs to be provided", ex.Message);
        }

        [TestCase("")]
        [TestCase("NAN")]
        [TestCase("3.2")]
        [TestCase("3000000000")]
        public void ParseAndSum_InvalidFormat_Throws(string input)
        {
            var parser = MakeParser();
            var ex = Assert.Catch<FormatException>(() => parser.ParseAndSum(input));

            StringAssert.Contains("argument needs to be an int32", ex.Message);
        }

        [Test]
        public void ParseAndSum_OneNumber_ReturnsThatNumber()
        {
            var parser = MakeParser();
            var result = parser.ParseAndSum("1");

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ParseAndSum_TwoNumbers_SumsThem()
        {
            var parser = MakeParser();
            var result = parser.ParseAndSum("1,2");

            Assert.AreEqual(3, result);
        }

    }
}
