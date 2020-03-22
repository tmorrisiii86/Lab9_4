using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_4_Thomas_Morris
{
    class Header
    {
        public const string open = "<h1>";
        public const string close = "</h1>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(open, text, close, "\n");
            return header;
        }

    }
}
