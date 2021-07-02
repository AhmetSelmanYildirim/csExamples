using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] colors = new string[5];

            string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

            int[] arr;
            arr = new int[5];

            //Access
            colors[0] = "Blue";

            arr[3] = 10;

            System.Console.WriteLine(animals[1]);
            System.Console.WriteLine(arr[3]);
            System.Console.WriteLine(colors[0]);

            //loop - array

            System.Console.Write("How many number you will enter: ");
            int n = int.Parse(Console.ReadLine());

            int[] values = new int[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Enter {0}. number: ", i + 1);
                values[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            System.Console.WriteLine("Avarage: " + sum / n);

        }
    }
}
