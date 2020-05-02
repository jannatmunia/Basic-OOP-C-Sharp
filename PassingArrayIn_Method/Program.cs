using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArrayIn_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[3];
            data[0] = "CE";
            data[1] = "SE";
            data[2] = "CE";
            method(data);
            int[] agedata = new int[2];
            agedata[0] = 20;
            agedata[1] = 30;
            age(agedata);

            Console.ReadKey();
        }
        public static void method(string[] name)
        {
            foreach (string value in name)
            {
                Console.WriteLine(value);
            }
        }
        public static void age(int[] age)
        {
            foreach(int value in age)
            {
                Console.WriteLine(value);
            }
        }
    }
}
