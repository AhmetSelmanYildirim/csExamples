using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Out parameters
            string num = "999";


            bool result = int.TryParse(num, out int outNum);
            if (result)
            {
                System.Console.WriteLine("Successfull");
                System.Console.WriteLine(outNum);
            }
            else
            {
                System.Console.WriteLine("Failed");
            }

            Methods instance = new Methods();
            instance.Sum(4, 5, out int sumRes);
            System.Console.WriteLine(sumRes);

            //Method overloading

            int s = 999;
            instance.printToScreen(s);
            instance.printToScreen("Ahmet", "YILDIRIM");


        }
    }

    class Methods
    {
        public int Sum(int a, int b, out int sum)
        {
            sum = a + b;
            return sum;
        }

        public void printToScreen(string data)
        {
            System.Console.WriteLine(data);
        }
        public void printToScreen(int data)
        {
            System.Console.WriteLine(data);
        }

        public void printToScreen(string data1, string data2)
        {
            System.Console.WriteLine(data1 + data2);
        }
    }

}
