﻿using NUnit.Framework;

namespace OFXParser.Test
{
    [TestFixture]
    public class OFXParserTest
    {
        [Test]
        public void ShouldParseValidExtract()
        {
            var extract = OFXParser.GetExtract("E:\\extract.ofx");
        }
    }
}
