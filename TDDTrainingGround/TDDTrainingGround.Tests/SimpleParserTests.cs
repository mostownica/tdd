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

        [Test]
        public void ParseAndSum_EmptyParameter_Throws()
        {
            var parser = MakeParser();

            var ex = Assert.Catch<ArgumentNullException>(() => parser.ParseAndSum(null));

            StringAssert.Contains("argument needs to be provided", ex.Message);
        }

    }
}
