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

        [TestCase(null)]
        [TestCase("")]
        public void ParseAndSum_EmptyParameter_Throws(string input)
        {
            var parser = MakeParser();

            var ex = Assert.Catch<ArgumentNullException>(() => parser.ParseAndSum(input));

            StringAssert.Contains("argument needs to be provided", ex.Message);
        }

        [Test]
        public void ParseAndSum_NotANumber_Throws()
        {
            var parser = MakeParser();
            var ex = Assert.Catch<ArgumentNullException>(() => parser.ParseAndSum("NAN"));

            StringAssert.Contains("argument needs to be a number", ex.Message);
        }

        [Test]
        public void ParseAndSum_FloatNumber_Throws()
        {
            var parser = MakeParser();
            var ex = Assert.Catch<InvalidOperationException>(() => parser.ParseAndSum("3.2"));

            StringAssert.Contains("argument needs to be an int32", ex.Message);
        }

        [Test]
        public void ParseAndSum_BigNumber_Throws()
        {
            var parser = MakeParser();
            var ex = Assert.Catch<InvalidOperationException>(() => parser.ParseAndSum("3000000000"));

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
