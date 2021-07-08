using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.Name = "Alex";
            student.Surname = "De Souza";
            student.StudentNo = 10;
            student.Grade = 4;
            student.GetStudentInfo();

            student.GradeUp();
            student.GetStudentInfo();

            System.Console.WriteLine("********");
            Student student1 = new Student("Kezman", "UDN", 7, 1);
            student1.GradeDown();
            student1.GradeDown();
            student1.GetStudentInfo();



        }
    }

    class Student
    {

        private string name;
        private string surname;
        private int studentNo;
        private int grade;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int Grade
        {
            get => grade;
            set
            {
                if (value < 1)
                {
                    System.Console.WriteLine("Grade can't be lower than 1");
                    grade = 1;
                }
                else
                    grade = value;
            }
        }

        public Student(string name, string surname, int studentNo, int grade)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            Grade = grade;
        }

        public Student()
        {

        }

        public void GetStudentInfo()
        {

            Console.WriteLine("Student Name: {0}", this.Name);
            Console.WriteLine("Student Surname: {0}", this.Surname);
            Console.WriteLine("Student No: {0}", this.StudentNo);
            Console.WriteLine("Student Grade: {0}", this.Grade);
        }

        public void GradeUp() { this.Grade = this.Grade + 1; }

        public void GradeDown()
        {
            this.Grade = this.Grade - 1;
        }
    }
}
