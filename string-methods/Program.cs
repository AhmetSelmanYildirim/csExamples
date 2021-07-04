using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = "Lesson is CSharp Welcome!";
            string variable2 = "CSharp";

            //Length
            Console.WriteLine(variable.Length);

            //ToUpper - ToLower
            Console.WriteLine( variable.ToUpper() );
            Console.WriteLine( variable.ToLower() );

            //Concat
            Console.WriteLine(String.Concat(variable," Hello!"));

            //Compare - CompareTo
            Console.WriteLine(variable.CompareTo(variable2)); //0,1,-1
            Console.WriteLine(String.Compare(variable,variable2,true)); //0,1,-1
            Console.WriteLine(String.Compare(variable,variable2,false)); //0,1,-1

            //Contains
            Console.WriteLine(variable.Contains(variable2));
            Console.WriteLine(variable.EndsWith("Welcome!"));
            Console.WriteLine(variable.StartsWith("Hello!"));

            //IndexOf
            Console.WriteLine(variable.IndexOf("CS"));
            Console.WriteLine(variable.IndexOf("ASY"));
            Console.WriteLine(variable.LastIndexOf("e"));

            //Insert
            Console.WriteLine(variable.Insert(0,"Hello "));

            //PadLeft - PadRight
            Console.WriteLine(variable + variable2.PadLeft(30));
            Console.WriteLine(variable + variable2.PadLeft(30,'-'));
            Console.WriteLine(variable.PadRight(50) + variable2);
            Console.WriteLine(variable.PadRight(50,'*') + variable2);

            //Remove
            Console.WriteLine(variable.Remove(10));
            Console.WriteLine(variable.Remove(10,3));
            Console.WriteLine(variable.Remove(0,1));

            //Replace
            Console.WriteLine(variable.Replace("CSharp", "C#"));
            Console.WriteLine(variable.Replace(" ", "-"));

            //Split
            Console.WriteLine(variable.Split(' ')[1]);

            //Substring
            Console.WriteLine(variable.Substring(4));
            Console.WriteLine(variable.Substring(4,6));
            
        }
    }
}
