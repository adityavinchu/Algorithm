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

            //Console.WriteLine("Enter List of words saperated by comma',' ");
            //string input = Console.ReadLine();
            //string[] list = input.Split(',');

            //BinarySearch binarysearch = new BinarySearch();
            //List<string> Sortedlist = new List<string>();
            //foreach (string str in list)
            //{
            //    Sortedlist.Add(str);
            //}
            //Sortedlist.Sort();
            //int i = 0;
            //foreach (string str in Sortedlist)
            //{
            //    list[i] = str;
            //    i++;
            //}
            //Console.WriteLine("Enter the string to search");
            //string tosearch = Console.ReadLine();
            //int position = binarysearch.Search(list, tosearch, 0, list.Length - 1);
            //if (position != -1)
            //{
            //    Console.WriteLine("Element is present at index: " + position);
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Element is not present");
            //    Console.ReadLine();
            //}

            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.Sort(list);


            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.Sort(list);
            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine(list[i] + " ");
            //}
            //Console.ReadLine();


            Console.WriteLine("Enter Number upto which you want prime numbers");
            int num=Convert.ToInt32(Console.ReadLine());
            PrimeNumber prime = new PrimeNumber();
            prime.PrintPrime(num);


        }
    }
}
