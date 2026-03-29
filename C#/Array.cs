using System;
//provides methods to use in an array
using System.Linq;
namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Element in first index:" + numbers[0]);
            Console.WriteLine("Element in second index:" + numbers[1]);
            Console.WriteLine("Element in third index:" + numbers[2]);
            //
            Console.WriteLine("\n Access array using loop:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element in index {0}:{1}", i, numbers[i]);
            }
            // 2 Dimensional Array
            int[,] numbers2 = { { 12, 13 }, { 55, 77 } };
            Console.WriteLine("Element at index[0,0]:" + numbers2[0, 0]);
            Console.WriteLine("Element at index [1,0]:" + numbers2[1, 0]);

            //array & foreach 1
            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender)
            {

                if (g == 'm')
                    male++;
                else
                    female++;

            }
            Console.WriteLine("Number of male ={0}", male);
            Console.WriteLine("Number of female ={0}", female);

            //array & foreach 2
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };
            foreach (char ch in myArray)
            {
                Console.Write(ch);

        }
            //with system.linq
            int[] num = { 51, -1, 2, 14, 18, 40, 178 };
            Console.WriteLine("\nMinimum number:" + num.Min());
            Console.WriteLine( "Maximum number:"+num.Max());
            Console.WriteLine("Count:"+num.Count());
            Console.WriteLine("Sum:"+num.Sum());
            Console.WriteLine("Average:"+num.Average());
        
        
        
        
        
        
        
        
        
        }
    }
}
