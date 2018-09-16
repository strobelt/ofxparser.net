using System;

namespace OfxParser.Core
{
    class OfxParserException : Exception
    {
        public OfxParserException() : base()
        {
        }

        public OfxParserException(string message) : base(message)
        {
        }

        public OfxParserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
