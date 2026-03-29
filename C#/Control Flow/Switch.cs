using System;
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch
            char ch;
            Console.WriteLine("Enter a letter");
            ch = Convert.ToChar(Console.ReadLine());
                switch (char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                    default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
            //simple calculater by switch
            char op;
            double first, second, result;
            Console.WriteLine("Enter First Number:");
            first=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            second=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator (+,-,*,/):");
            op=Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    result=first+second;
                    Console.WriteLine("{0} + {1} = {2}",first,second,result);
                    break;
                case '-':
                    result=first-second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;
                    case '*':
                    result=first*second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;
                case '/':
                    result=first/second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            //string compare
            string Name = "Lemar";
            switch (Name.ToLower())
            {
                case "lemar":
                    Console.WriteLine("Yes Lemar");
                    break;
                case "ali":
                    Console.WriteLine("Yes Ali");
                    break;
                default:
                    Console.WriteLine("No Name Matched!");
                    break;
            }
            Console.ReadKey();


        }
    }
}
