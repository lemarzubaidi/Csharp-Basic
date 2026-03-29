using System;
namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Unary operaters
            int number = 10, result;
            bool flag = true;
            result = +number;
            Console.WriteLine(result);
            result = -number;
            Console.WriteLine(result);
            result = ++number;
            Console.WriteLine(result);
            result = --number;
            Console.WriteLine(result);
            //
            Console.WriteLine("!flag="+(!flag));
            Console.WriteLine((number++));
            Console.WriteLine((number));
            Console.WriteLine((++number));
            Console.WriteLine((number));
            //Ternary Operator
            int num = 12;
            string x;
            x = (number % 2 == 0) ? "Even number" : "Odd number";
            Console.WriteLine("{0} is {1}",number,x);

        }
    }
}
