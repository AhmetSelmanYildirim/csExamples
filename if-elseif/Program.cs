using System;

namespace if_elseif
{
    class Program
    {
        static void Main(string[] args)
        {

            int time = DateTime.Now.Hour;

            if (time < 12 && time >= 6)
            {
                System.Console.WriteLine("Good morning");
            }
            else if (time <= 18 && time >= 12)
            {
                System.Console.WriteLine("Good afternoon");
            }
            else
            {
                System.Console.WriteLine("Good evening");
            }

            string result = time <= 18 ? "Good afternoon" : "Good evening";

            result = time < 12 && time >= 6 ? "Good morning" : time <= 18 && time >= 12 ? "Good afternoon" : "Good evening";

            System.Console.WriteLine(result);

        }
    }
}
