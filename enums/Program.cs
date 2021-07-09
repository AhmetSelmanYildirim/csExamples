using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Saturday);

            int temp = 32;
            if (temp <= (int)Weather.Normal)
            {
                Console.WriteLine("It's cold to go outside");
            }
            else if (temp >= (int)Weather.Hot)
            {
                Console.WriteLine("It's so hot");
            }
            else if (temp >= (int)Weather.Normal && temp < (int)Weather.VeryHot)
            {
                Console.WriteLine("Let's go to outside");
            }

        }
    }

    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 23,
        Saturday,
        Sunday,

    }

    enum Weather
    {
        Cold = 5,
        Normal = 20,
        Hot = 25,
        VeryHot = 30,
    }

}
