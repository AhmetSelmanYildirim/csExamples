using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            System.Console.WriteLine(a + b);

            int result = Sum(a, b);
            System.Console.WriteLine(result);

            Methods ex = new Methods();
            ex.printToScreen(result.ToString());

            int result2 = ex.increaseAndSum(ref a, ref b);
            ex.printToScreen(result2.ToString());
            ex.printToScreen(Convert.ToString(a + b));
        }
        static int Sum(int x, int y)
        {
            return (x + y);
        }
    }

    class Methods
    {

        public void printToScreen(string data)
        {
            System.Console.WriteLine(data);
        }
        public int increaseAndSum(ref int x, ref int y)
        {
            x++;
            y++;
            return x + y;
        }
    }
}
