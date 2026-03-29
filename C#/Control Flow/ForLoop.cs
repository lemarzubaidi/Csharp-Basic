using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forward Loop
            Console.WriteLine("\nForward Loop:");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nBackword Loop:");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nNested Loop:");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("i={0} and j={1}", i, j);
                }
            }
        }
    }
}
