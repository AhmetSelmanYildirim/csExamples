using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Ahmet");
            list.Add(25);
            list.Add(true);
            list.Add('A');

            System.Console.WriteLine(list[1]);

            foreach (var item in list)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();

            //AddRange
            Console.WriteLine("***** AddRange *****");
            string[] colors = { "red", "yellow", "green" };
            List<int> numbers = new List<int>() { 1, 8, 3, 7, 5, 6 };

            list.AddRange(colors);
            list.AddRange(numbers);

            foreach (var item in list)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();

            //Sort //only same input type
            // Console.WriteLine("***** Sort *****");
            // list.Sort(); 

            //Binary Search
            // System.Console.WriteLine("***** Binary Search *****");
            // System.Console.WriteLine(list.BinarySearch(9));

            //Reverse
            // System.Console.WriteLine("***** Reverse *****");
            // list.Reverse();

            //Clear
            list.Clear();

        }
    }
}
