using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Room bedroom = new Room();
            Room drawingroom = new Room();
            Room diningroom = new Room();
            bedroom.width = 9;
            Console.WriteLine(bedroom.area());
            drawingroom.height = 10;
            drawingroom.width = 9;
            Console.WriteLine(drawingroom.area());
            diningroom.height = 50;
            diningroom.width = 10;
            Console.WriteLine(diningroom.area());
            Console.ReadKey();

        }
        class Room
        {
           
            public double width;
            public double height;
            public double area()
            {
                return height * width;
            }
        }
    }
}
