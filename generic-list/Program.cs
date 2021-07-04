using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T-> object

            List<int> numberList = new List<int>();

            numberList.Add(12);
            numberList.Add(5);
            numberList.Add(1);
            numberList.Add(18);
            numberList.Add(71);
            numberList.Add(122);

            List<string> colorList = new List<string>();

            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Yellow");
            colorList.Add("Green");

            //Count
            Console.WriteLine(colorList.Count);
            Console.WriteLine(numberList.Count);

            foreach (var num in numberList)
            {
                System.Console.Write(num+" ");
            }
            foreach (var color in colorList)
            {
                System.Console.Write(color+" ");
            }
            System.Console.WriteLine();

            numberList.ForEach(num => Console.Write(num + " "));
            colorList.ForEach(color => Console.Write(color + " "));
            System.Console.WriteLine();

            //Removing
            numberList.Remove(1);
            colorList.Remove("Green");
            numberList.ForEach(num => Console.Write(num + " "));
            colorList.ForEach(color => Console.Write(color + " "));
            System.Console.WriteLine();

            numberList.RemoveAt(0);
            colorList.RemoveAt(1);
            numberList.ForEach(num => Console.Write(num + " "));
            colorList.ForEach(color => Console.Write(color + " "));
            System.Console.WriteLine();

            //Searching
            if(numberList.Contains(122)){
                System.Console.WriteLine("122 Found");
            }

            //Finding index of element
            Console.WriteLine(colorList.BinarySearch("Yellow"));

            //Array to List
            string[] animals = {"cat","dog","bird"};
            List<string> animalsList = new List<string>(animals);

            //Clear list
            animalsList.Clear();

            //object in List
            List<Users> userList = new List<Users>();
            Users user1 = new Users();
            user1.Name="Ahmet";
            user1.Surname="YILDIRIM";
            user1.Age=25;
            Users user2 = new Users();
            user2.Name="Yusuf";
            user2.Surname="Kerem";
            user2.Age=16;

            userList.Add(user1);
            userList.Add(user2);

            List<Users> newList = new List<Users>();
            newList.Add(new Users(){
                Name="Harley",
                Surname="Reis",
                Age=1
            });

            foreach (var user in userList)
            {
                System.Console.WriteLine("Username: "+user.Name);
                System.Console.WriteLine("Surname: "+user.Surname);
                System.Console.WriteLine("Age: "+user.Age);
            }

        }
    }

    public class Users{
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value;}
        public string Surname { get => surname; set => surname = value;}
        public int Age { get => age; set => age = value;}
    }
}
