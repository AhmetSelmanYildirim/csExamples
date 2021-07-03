using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***** First assignment *****");
            firstAssigment();
            System.Console.WriteLine("***** Second assignment *****");
            secondAssignment();
            System.Console.WriteLine("***** Third assignment *****");
            thirdAssignment();
            System.Console.WriteLine("***** Fourth assignment *****");
            fourthAssignment();



        }

        public static void firstAssigment()
        {

            Console.Write("How many num you will enter (Numbers must be positive): ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.number: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Even Numbers");
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    System.Console.Write(item + " ");
                }
            }
            Console.WriteLine();

        }

        public static void secondAssignment()
        {

            Console.Write("Enter a number (Number must be positive): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("How many num you will enter (Numbers must be positive): ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.number: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Divisible numbers");
            foreach (var item in numbers)
            {
                if (m % item == 0)
                {
                    Console.Write(item + " ");
                }

            }

        }

        public static void thirdAssignment()
        {

            Console.Write("How many word you will enter: ");
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.word: ", i + 1);
                words[i] = Convert.ToString(Console.ReadLine());
            }
            Array.Reverse(words);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }

        public static void fourthAssignment()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            int wordsCount = sentence.Split().Length;
            System.Console.WriteLine("Word count: "+wordsCount);
            int lettersCount =0;

            string splittedSentence = sentence.Replace(" ","");
            foreach (var item in splittedSentence)
            {
                lettersCount++;
            }

            System.Console.WriteLine("Letter count: "+lettersCount);


        }
    }
}
