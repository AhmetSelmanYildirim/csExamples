using System;

namespace static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Employee: {0}", Employee.EmployeeNumber);

            Employee employee = new Employee("Nicolas", "Anelka", "Forward");
            Console.WriteLine("Number of Employee: {0}", Employee.EmployeeNumber);
            Employee employee1 = new Employee("Mert", "Nobre", "Mid");
            Employee employee2 = new Employee("Stephen", "Appiah", "Right");
            Console.WriteLine("Number of Employee: {0}", Employee.EmployeeNumber);

            System.Console.WriteLine("Adding result: " + Operations.Add(100, 200));
            System.Console.WriteLine("Substraction result: " + Operations.Sub(100, 200));



        }
    }

    class Employee
    {
        private static int employeeNumber;

        public static int EmployeeNumber { get => employeeNumber; }

        private string Name;
        private string Surname;
        private string Department;

        static Employee()
        {
            employeeNumber = 0;
        }

        public Employee(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
            employeeNumber++;
        }
    }

    static class Operations
    {
        public static long Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static long Sub(int num1, int num2)
        {
            return num1 - num2;
        }
    }

}
