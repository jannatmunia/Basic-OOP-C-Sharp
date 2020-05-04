using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(multi(10.10));
            Console.WriteLine(multi(10));
            Console.WriteLine(multi("x"));
            Console.WriteLine(multi('a'));
            Console.ReadKey();
        }
        public static double multi(double x)
        {
            return x * x;
        }
        public static int multi(int x)
        {
            return x * x;
        }
        public static string multi(string y)
        {
            string st = "hello";
            return st + y;
        }
        public static char multi(char a)
        {
            return a;
        }
    }
}
