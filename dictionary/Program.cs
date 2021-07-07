using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> users = new Dictionary<int, string>();

            users.Add(25, "Ahmet");
            users.Add(16, "Yusuf");
            users.Add(10, "Ayse");

            //Access
            Console.WriteLine("***** Access *****");
            Console.WriteLine(users[25]);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("***** Count *****");
            System.Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(users.ContainsKey(25));
            Console.WriteLine(users.ContainsValue("Ali"));

            //Remove
            Console.WriteLine("***** Remove *****");
            users.Remove(25);
            foreach (var item in users)
            {
                System.Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("***** Keys *****");
            foreach (var item in users.Keys)
            {
                System.Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("***** Values *****");
            foreach (var item in users.Values)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
