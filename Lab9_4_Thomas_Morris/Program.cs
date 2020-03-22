using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4_Thomas_Morris
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C://weblogs//9_4Lab.html";
            Header header = new Header();
            UnorderedList list = new UnorderedList();
            StringBuilder sB = new StringBuilder();

            Console.WriteLine("Enter Text for HTML Header.");
            string headerText = header.CreateHeader(Console.ReadLine());
            string[] listItems = new string[3];

            for(int i = 0; i < listItems.Length; i++)
            {
                Console.WriteLine("Add Another Item to the List.");
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }

            StringBuilder listText = list.CreateList(listItems);
            sB.Append(headerText);
            sB.Append(listText.ToString());

            File.AppendAllText(filename, sB.ToString());
        }
    }
}
