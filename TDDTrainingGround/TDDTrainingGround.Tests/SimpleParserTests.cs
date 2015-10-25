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

    }
}
