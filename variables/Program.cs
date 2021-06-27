using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b = 5;    // 1byte
            sbyte sb = 5;  // 1byte
            short s = 5;   // 2byte
            ushort us = 5; // 2byte

            Int16 i16 = 2; // 2byte
            int value = 2; // 4byte
            Int32 i32 = 2; // 4byte
            Int64 i64 = 2; // 8byte

            uint ui = 2;   // 4byte
            long l = 4;    // 8byte
            ulong ul = 4;  // 8byte

            float f = 5;   // 4byte 
            double d = 5;  // 8byte
            decimal de = 5; // 16byte

            char ch = '2'; // 2byte
            string str = "ASY"; //unlimited

            bool b1 = true;            
            bool b11 = 10<2;

            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = 3;

            //String

            string str1 = string.Empty;
            str1 = "ASY";
            string name = "Ahmet";
            string surname = "YILDIRIM";
            string fullname = name +" "+surname;



            //Transformation

            string str20 = "20";
            int int20 = 20;

            string newValue = str20 + int20.ToString();
            int int21 = int20 + Convert.ToInt32(str20);
            int int22 = int20 + int.Parse(str20);

            //datetime

            string datetime = DateTime.Now.ToString("dd/MM/yyyy");
            string datetimeHour = DateTime.Now.ToString("HH.mm");

            Console.WriteLine(datetimeHour);
        }
    }
}
