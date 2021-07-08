using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // class ClassName
            // {
            //     Access Modifier Data Type propertyName;
            // }

            //Access Modifier
            // Public - Access from everywhere
            // Private - Access from only same class
            // Internal - Access from only same project
            // Protected - Acces from same class or inherited classes


            Employee employee1 = new Employee("Ahmet", "YILDIRIM", 21601408, "CS");

            employee1.EmployeeInfo();

            Console.WriteLine();
            Employee employee2 = new Employee();
            employee2.Name = "Yusuf";
            employee2.Surname = "Kerem";
            employee2.Nu = 1347;
            employee2.Department = "HS";
            employee2.EmployeeInfo();

            Employee employee3 = new Employee("Salih", "Ucan");
            employee3.EmployeeInfo();

        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int Nu;
        public string Department;

        public Employee(string name, string surname, int nu, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Nu = nu;
            this.Department = department;
        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Employee() { }

        public void EmployeeInfo()
        {
            Console.WriteLine("*****");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("Number: {0}", Nu);
            Console.WriteLine("Department: {0}", Department);
        }



    }
}
