using System;

namespace CallByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first parameter:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second parameter: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter thisd parameter:");
            int z = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            int sum = obj.method(x, y, z);
            int sub = obj.method(y, z);
            int mul = obj.method(z);
            Console.WriteLine("the result is:{0}",sum);
            Console.WriteLine("the result is:{0}", sub);
            Console.WriteLine("the result is:{0}", mul);
            Console.ReadKey();
        }
        public int method(int b, int c)
        {
            return b - c;
        }
        public int method(int f)
        {
            return f * f;
        }
        public int method(int a,int b,int c)
        {
            return  a + b + c;
        }
    }
}
