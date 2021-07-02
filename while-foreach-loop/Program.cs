using System;

namespace while_foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            int sum = 0;

            while (counter <= num)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine(sum / num);

            char c = 'a';
            while (c <= 'z')
            {
                Console.Write(c);
                c++;
            }
            System.Console.WriteLine("\n*****Foreach*****");
            string[] cars = { "BMW", "Ford", "VW", "Mercedes" };

            foreach (var car in cars)
            {
                System.Console.WriteLine(car);
            }

        }
    }
}
