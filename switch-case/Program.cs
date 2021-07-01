using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {

            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    System.Console.WriteLine("January");
                    break;
                case 2:
                    System.Console.WriteLine("February");
                    break;
                case 3:
                    System.Console.WriteLine("March");
                    break;
                case 4:
                    System.Console.WriteLine("April");
                    break;
                case 5:
                    System.Console.WriteLine("May");
                    break;
                case 6:
                    System.Console.WriteLine("June");
                    break;
                case 7:
                    System.Console.WriteLine("July");
                    break;
                default:
                    System.Console.WriteLine("Wrong input");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("It'is Winter");
                    break;

                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("It'is Spring");
                    break;

                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("It'is Summer");
                    break;

                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("It'is Autumn");
                    break;

            }

        }
    }
}
