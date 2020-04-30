using System;
namespace MultipleValuesFromSingleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a no :");
            int y = Convert.ToInt32(Console.ReadLine());
            int sum, sub,mul,div;
            /*out is a simple keyword
             */
            method(x, y,out sum,out sub,out mul,out div);
            Console.WriteLine("sum,substraction,multiplication,division is : {0},{1},{2},{3}", sum, sub,mul,div);
            Console.ReadKey();
        }
        public static void method(int a,int b,out int sum,out int sub,out int mul,out int div)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }
       
    }
}
