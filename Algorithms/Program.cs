using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarysearch = new BinarySearch();

            Console.WriteLine("Enter List of words saperated by comma',' ");

            string input = Console.ReadLine();
            string[] list = input.Split(',');

            List<string> Sortedlist = new List<string>();

            foreach (string str in list)
            {
                Sortedlist.Add(str);
            }

            Sortedlist.Sort();
            int i = 0;
            foreach (string str in Sortedlist)
            {
                list[i] = str;
                i++;
            }

            Console.WriteLine("Enter the string to search");
            string tosearch = Console.ReadLine();
            int position = binarysearch.Search(list, tosearch, 0, list.Length - 1);
            if (position != -1)
            {
                Console.WriteLine("Element is present at index: " + position);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Element is not present");
                Console.ReadLine();
            }
        }
    }
}
