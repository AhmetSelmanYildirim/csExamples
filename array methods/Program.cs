using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sort
            int[] numbers = {23,12,4,86,72,3,11,17};

            System.Console.WriteLine("*****Unsorted Array*****");
            foreach (var number in numbers)
            {
                System.Console.Write(number+" ");
            }
            System.Console.WriteLine("\n*****Sorted Array*****");
            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                System.Console.Write(number+" ");
            }

            //Clear
            System.Console.WriteLine("\n*****Clear Array*****");
            Array.Clear(numbers,2,1);

            foreach (var number in numbers)
            {
                System.Console.Write(number+" ");
            }

            //Reverse
            System.Console.WriteLine("\n*****Reverse Array*****");
            Array.Reverse(numbers);

            foreach (var number in numbers)
            {
                System.Console.Write(number+" ");
            }

            //IndexOf
            System.Console.WriteLine("\n*****IndexOf Array*****");
            System.Console.Write(Array.IndexOf(numbers,23));

            //Resize
            System.Console.WriteLine("\n*****Resize Array*****");
            Array.Resize<int>(ref numbers,9);
            numbers[8]=99;
            foreach (var number in numbers)
            {
                System.Console.Write(number+" ");
            }

        }
    }
}
