using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependency
{
    public class Copy
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public Copy(IReader _reader, IWriter _writer)
        {
            reader = _reader;
            writer = _writer;
        }

        public void CopyAllChars()
        {
            string text = reader.Read();
            writer.Write(text);
        }
    }
}
