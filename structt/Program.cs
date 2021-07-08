using System;

namespace structt
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.shortEdge = 2;
            rectangle.longEdge = 5;

            System.Console.WriteLine("Class Rectangle Area: {0}", rectangle.CalculateArea());

            Rectangle_Struct rectangle_struct = new Rectangle_Struct(3,4);

            System.Console.WriteLine("Struct Rectangle Area: {0}", rectangle_struct.CalculateArea());

        }
    }

    class Rectangle
    {
        public int shortEdge;
        public int longEdge;

        public Rectangle(){
            shortEdge=3;
            longEdge=8;
        }

        public long CalculateArea()
        {
            return this.longEdge * this.shortEdge;
        }
    }

    struct Rectangle_Struct
    {
        public int shortEdge;
        public int longEdge;

        public Rectangle_Struct(int shortEdge, int longEdge)
        {
            this.shortEdge = shortEdge;
            this.longEdge = longEdge;
        }
        public long CalculateArea()
        {
            return this.longEdge * this.shortEdge;
        }
    }


}
