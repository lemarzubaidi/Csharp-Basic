using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        //try catch
        static void Main(string[] args)
        {
            try
            {
                int[] num = { 1, 2, 3 };
                Console.WriteLine(num[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // random function
            Random rnd=new Random();
            for (int i = 0; i < 4; i++) ;
            Console.WriteLine(rnd.Next(10, 20)) ;
        }
    }
}
