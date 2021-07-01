using System;

namespace error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.Write("Type a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your number is: " + num);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error: " + e.Message.ToString());
            }
            finally
            {
                System.Console.WriteLine("Process finished");
            }
            */


            try
            {
                // int a = int.Parse(null);
                // int b = int.Parse("test");
                int c = int.Parse("111111111111");

            }
            catch (ArgumentNullException e)
            {
                System.Console.WriteLine("Empty value entered");
                System.Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                System.Console.WriteLine("Data type incorrect");
                System.Console.WriteLine(e);
            }
            catch(OverflowException e){
                System.Console.WriteLine("Out of range value entered");
                System.Console.WriteLine(e);
            }
            finally{
                System.Console.WriteLine("Process finished");
            }

        }
    }
}
