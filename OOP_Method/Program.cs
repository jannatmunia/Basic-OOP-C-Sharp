using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.method();
            Console.ReadKey();

        }
        /*
        Access Specifier return type method_name (Parameter List)
        {
            Method Body;
        }
        */
        public void method()
        {
            Console.WriteLine("This is a method");
        }
    }
}
