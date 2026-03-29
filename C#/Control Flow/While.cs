using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Loop
          int i = 1;
            while (i <= 5)
            {
                if (i == 3)
                {
                    i++;
                    continue;

                }
                else
                {
                    Console.WriteLine("C# While Loop: iteration1 {0}", i);
                    i++;
                }
            } 
            // Do..While Loop
           int j = 1;
            do
            {
                Console.WriteLine("C# While Loop: iteration {0}", j);
                if (j == 3)
                    break;
                j++;
            }while (j <= 5);
        }
    }
}
