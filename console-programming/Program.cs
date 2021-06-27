using System;

namespace console_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your Surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
            
        }
    }
}
