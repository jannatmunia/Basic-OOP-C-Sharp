using System;

namespace CallByReferenceMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Enter a variable:");
            int a = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(obj.reference(ref a));
            Console.WriteLine("a is {0}",a);
            Console.ReadKey();
        }
        public int reference(ref int z)
        {
            return z = 200;
        }
    }
}
