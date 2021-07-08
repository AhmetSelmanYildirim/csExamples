using System;

namespace classs
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


            Employee employee1 = new Employee();
            employee1.Name = "Ahmet";
            employee1.Surname = "YILDIRIM";
            employee1.Nu = 21601408;
            employee1.Department = "CS";

            employee1.EmployeeInfo();

            Employee employee2 = new Employee();
            employee2.Name = "Yusuf";
            employee2.Surname = "Kerem";
            employee2.Nu = 1347;
            employee2.Department = "HS";

            employee2.EmployeeInfo();

        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int Nu;
        public string Department;

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
