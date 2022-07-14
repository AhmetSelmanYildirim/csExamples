using System.Collections.Generic;

namespace project1
{
    class PhoneDirectory
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        

        List<Person> peopleList = new List<Person>();

        public void addPerson()
        {
            peopleList.Add(new Person()
            {
                Name = "Ahmet",
                Surname = "YILDIRIM",
                Phone = "5412325468"
            });
        }

        public void printP(){
            foreach (var item in peopleList)
            {
            System.Console.WriteLine("Name: "+item.Name);
            System.Console.WriteLine("Surname: "+item.Surname);
            System.Console.WriteLine("Phone: "+item.Phone);
               
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