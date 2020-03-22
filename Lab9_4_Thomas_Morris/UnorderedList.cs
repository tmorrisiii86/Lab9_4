using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_4_Thomas_Morris
{
    class UnorderedList
    {
        public const string open = "<ul>";
        public const string close = "</ul>";

        public string CreateListItem(string text)
        {
            string open = "<li>\n";
            string close = "</li>\n";

            string listItem = String.Concat(open, text, close, "\n");
            return listItem;
        }

        public StringBuilder CreateList(string[] listItems)
        {
            StringBuilder sB = new StringBuilder();
            sB.Append(open);
            foreach(string item in listItems)
            {
                sB.Append(item);
            }
            sB.Append(close);
            return sB;
        }
    }
}
