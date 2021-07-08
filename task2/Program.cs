using System;
using System.Collections;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            // System.Console.WriteLine("***** First assignment *****");
            // firstAssigment();
            // System.Console.WriteLine("***** Second assignment *****");
            // secondAssignment();
            System.Console.WriteLine("***** Third assignment *****");
            thirdAssignment();






        }

        public static void firstAssigment()
        {

            ArrayList primeNumbers = new ArrayList();
            ArrayList nonprimeNumbers = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Write("{0}.number: ", i + 1);
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        Console.WriteLine("Please enter a positive number.");
                        i--;
                    }
                    else
                    {

                        if (IsPrime(number))
                        {
                            primeNumbers.Add(number);
                        }
                        else
                        {
                            nonprimeNumbers.Add(number);
                        }

                    }

                }
                catch (FormatException e)
                {
                    System.Console.WriteLine("Data type incorrect");
                    i--;
                }


            }

            primeNumbers.Sort();
            primeNumbers.Reverse();
            nonprimeNumbers.Sort();
            nonprimeNumbers.Reverse();

            Console.Write("Prime numbers: ");
            foreach (var item in primeNumbers)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();

            Console.Write("Non-Prime numbers: ");
            foreach (var item in nonprimeNumbers)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
            Console.WriteLine("Prime numbers length: {0}", primeNumbers.Count);
            Console.WriteLine("Non-Prime numbers length: {0}", nonprimeNumbers.Count);

            //Ortalama hesapla yazdır
            Console.Write("Avarage of prime numbers: ");
            int avarage = 0;
            foreach (var item in primeNumbers)
            {
                avarage += (int)item;
            }
            avarage /= primeNumbers.Count;
            Console.WriteLine(avarage);
            avarage = 0;

            Console.Write("Avarage of non prime numbers: ");
            foreach (var item in nonprimeNumbers)
            {
                avarage += (int)item;
            }
            avarage /= primeNumbers.Count;
            Console.WriteLine(avarage);

        }

        public static bool IsPrime(int number)
        {

            if (number <= 1) return false;
            if (number == 2) return false;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void secondAssignment()
        {

            int[] arr = new int[20];
            int[] lowNumbers = new int[3];
            int[] highNumbers = new int[3];

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Write("{0}.number: ", i + 1);
                    int number = int.Parse(Console.ReadLine());

                    arr[i] = number;

                }
                catch (FormatException e)
                {
                    System.Console.WriteLine("Data type incorrect");
                    i--;
                }
            }

            Array.Sort(arr);
            for (int i = 0; i <= 2; i++)
            {
                lowNumbers[i] = arr[i];
            }
            Array.Reverse(arr);
            for (int i = 0; i <= 2; i++)
            {
                highNumbers[i] = arr[i];
            }

            int avarageOfLowers = 0;
            foreach (var item in lowNumbers)
            {
                avarageOfLowers += item;
            }
            avarageOfLowers /= 3;
            Console.WriteLine("Avarage of the low 3 numbers: {0}", avarageOfLowers);

            int avarageOfHigher = 0;
            foreach (var item in highNumbers)
            {
                avarageOfHigher += item;
            }
            avarageOfHigher /= 3;
            Console.WriteLine("Avarage of the high 3 numbers: {0}", avarageOfHigher);

            int sum = avarageOfHigher + avarageOfLowers;
            Console.WriteLine("Sum of the avarages: {0}", sum);


        }

        public static void thirdAssignment()
        {

            Console.Write("Write a sentence: ");
            string sentence = Console.ReadLine();
            string[] vowel = new string[20];
            int index=0;
            sentence.ToLower();

            foreach (var item in sentence)
            {
                if(item == 'a'||item == 'e'||item == 'o'||item == 'u'||item == 'i'||item == 'ö'||item == 'ü'){
                    vowel[index] = item.ToString();
                    index++;
                }
                
            }
            Array.Sort(vowel);

            Console.Write("Vowel letters are: ");
            foreach (var item in vowel)
            {
                Console.Write(item+" ");
            }
        }




    }
}
