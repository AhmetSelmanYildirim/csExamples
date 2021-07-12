using System.Collections.Generic;

namespace project1
{
    class PhoneDirectory
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();


        List<Person> peopleList = new List<Person>();

        public void addPerson(string name, string surname, string phone)
        {
            peopleList.Add(new Person()
            {
                Name = name,
                Surname = surname,
                Phone = phone
            });
        }

        public void printAll()
        {
            foreach (var item in peopleList)
            {
                System.Console.WriteLine("Name: " + item.Name);
                System.Console.WriteLine("Surname: " + item.Surname);
                System.Console.WriteLine("Phone: " + item.Phone);
                System.Console.WriteLine("-");

            }
        }

        public int searchByName(string name)
        {
            foreach (var item in peopleList)
            {
                if (name == item.Name || name == item.Surname)
                {
                    System.Console.WriteLine("Search Results:");
                    System.Console.WriteLine("**********************************************");
                    System.Console.WriteLine("Name: {0}", item.Name);
                    System.Console.WriteLine("Surname: {0}", item.Surname);
                    System.Console.WriteLine("Phone: {0}", item.Phone);
                    return 1;
                }
            }
            return 0;
        }
        public void searchByPhone(string phone)
        {
            foreach (var item in peopleList)
            {
                if (phone == item.Phone)
                {
                    System.Console.WriteLine("Search Results:");
                    System.Console.WriteLine("**********************************************");
                    System.Console.WriteLine("Name: {0}", item.Name);
                    System.Console.WriteLine("Surname: {0}", item.Surname);
                    System.Console.WriteLine("Phone: {0}", item.Phone);
                }
            }
        }

        public void deleteNumber(string name)
        {
            int indexT = peopleList.FindIndex(r => r.Name == name || r.Surname == name);
            peopleList.RemoveAt(indexT);

        }

        public void updateNumber(string name, string number)
        {

            foreach (var item in peopleList)
            {
                if (item.Name == name || item.Surname == name)
                {
                    item.Phone = number;
                }
            }

        }

    }

    class Person
    {
        private string name;
        private string surname;
        private string phone;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }




    }




}