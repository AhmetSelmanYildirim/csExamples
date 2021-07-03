using System;

namespace recursice_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            System.Console.WriteLine(result);

            Operations instance = new();
            System.Console.WriteLine(instance.Expo(3, 4));

            //Extension Methods
            string expression = "Ahmet Selman YILDIRIM";
            bool result2 = expression.CheckSpaces();
            System.Console.WriteLine(result2);
            if (result2)
            {
                System.Console.WriteLine(expression.RemoveWhiteSpaces());
            }
            System.Console.WriteLine(expression.MakeUpperCase());
            System.Console.WriteLine(expression.MakeLowerCase());

            int[] arr = { 5, 8, 4, 2, 3, 41, 15, 6, 314 };
            arr.SortArray();
            arr.PrintToScreen();

            int num = 5;
            System.Console.WriteLine("/n" + num.IsEvenNumber());

            System.Console.WriteLine(expression.GetFirstCharacter());

        }
    }

    public class Operations
    {

        public int Expo(int num, int power)
        {
            if (power < 2)
            {
                return num;
            }
            return Expo(num, power - 1) * num;
        }

    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("*", arr);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void PrintToScreen(this int[] param)
        {
            foreach (var item in param)
            {
                System.Console.Write(item + " ");
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
