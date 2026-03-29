using System;

namespace ConsoleApp16
{
    internal class Program
    {
        //void
        static void print(string name,byte age,string Address="No Address")
        {
            Console.WriteLine("Name= {0},Age= {1},Address={2}",name,age,Address);
        }
        //return method
        static string getname()
        {

            return "lemar zubaidi";
        }
        //named arguments(key:value)
        static void mymethod(string child1,string child2,string child3)
        {
            Console.WriteLine("the youngest child is:"+child3);
        }
        //overloading methods
        static int sum(int num1,int num2)
        {
            return num1 + num2;
        }
        static int sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static int sum(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3+num4;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("max of 5,10 is: {0}", Math.Max(5, 10));
            Console.WriteLine("min of 5,10 is: {0}", Math.Min(5, 10));
            Console.WriteLine("Squir Root of 64 is:{0}",Math.Sqrt(64));
            Console.WriteLine("Absolute value of -4.7 is: {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99 is: {0}",Math.Round(9.99));
            print("lemar zubaidi",20);
            mymethod(child3: "omar", child1: "saqer", child2: "Hamza");
        }
    }
}
