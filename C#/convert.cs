using System;
namespace ConsoleApp9
{
    internal class Program
    {
        enum enweek
        {
            monday,
            tusday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main(string[] args)
        {
            //casting atuomatic
            int myInt = 17;
            double mydouble = myInt;
            Console.WriteLine(mydouble);
            Console.WriteLine(myInt);
            //casting manually
            double d = 17.58;
            int i = (int)d;
            Console.WriteLine(i);
            Console.WriteLine(d);
            //convert by function 
            int n = 20;
            double de = 7.25;
            bool b=true;    
            Console.WriteLine(Convert.ToString(n));
            Console.WriteLine(Convert.ToDouble(n));
            Console.WriteLine(Convert.ToInt32(de));
            Console.WriteLine(Convert.ToString(b));
            // convert enum
            Console.WriteLine(enweek.friday);
            int day=(int) enweek.friday;
            Console.WriteLine(day);
            var wd = (enweek)5;
            Console.WriteLine(wd);

        }
    }
}
