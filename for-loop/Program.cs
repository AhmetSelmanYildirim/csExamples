using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Type a number: ");
            int counter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= counter; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += i;
                }
                else
                {
                    evenSum += i;
                }
            }
            System.Console.WriteLine("Odd Sum: " + oddSum);
            System.Console.WriteLine("Even Sum: " + evenSum);


            //break,continue

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                break;
                System.Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                continue;
                System.Console.WriteLine(i);
            }


        }
    }
}
