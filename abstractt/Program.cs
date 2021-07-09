using System;

namespace abstractt
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFocus focus = new();
            Console.WriteLine(focus.WhichBrand());
            Console.WriteLine(focus.HowManyTires());
            Console.WriteLine(focus.StandardColor());

            System.Console.WriteLine();

            NewCivic civic = new();
            Console.WriteLine(civic.WhichBrand());
            Console.WriteLine(civic.HowManyTires());
            Console.WriteLine(civic.StandardColor());
        }
    }
}
