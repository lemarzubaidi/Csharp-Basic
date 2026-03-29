using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            dt=DateTime.Now;
            Console.WriteLine(dt);
            DateTime dt2 = new DateTime(2023, 12, 31);
            DateTime dt3 = new DateTime(2023,12,21);
            Console.WriteLine(dt3);
            Console.WriteLine(dt2);
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt4);
            //ticks
            DateTime start = DateTime.Now;
            Console.WriteLine(DateTime.MinValue.Ticks);
            DateTime end = DateTime.Now;
            long d = end.Ticks - start.Ticks;
            Console.WriteLine(d);
            Console.WriteLine(DateTime.MaxValue.Ticks);
            DateTime currentdatetime= DateTime.Now;
            DateTime todaydate= DateTime.Today;
            //time span
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);
            Console.WriteLine(ts.Milliseconds);
            //add time span to the date
            DateTime ds = dt2.Add(ts);
            Console.WriteLine(ds);
            //Substruct
            TimeSpan ts1 = dt2.Subtract(dt3);
            Console.WriteLine(ts1.Days);
            //operators
            DateTime d1 = new DateTime(2015, 12, 20);
            DateTime d2=new DateTime(2016,12, 31,5,10,20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);
            Console.WriteLine(d2+time);
            Console.WriteLine(d2-d1);
            Console.WriteLine(d1==d2);
            Console.WriteLine(d2!=d1);
            Console.WriteLine(d1>d2);
            Console.WriteLine(d2>d1);
            Console.WriteLine(d1>=d2);  
            Console.WriteLine(d1<=d2);
            //convert string to datetime
            var str = "6/12/2023";
            DateTime dr;
           var isvalid = DateTime.TryParse(str, out dr);
            if (isvalid)
            {
                Console.WriteLine(dr);
            }
            else
                Console.WriteLine("not valied");
            var str2 = "6/65/2023";
            DateTime dr2;
            var isvaliddate=DateTime .TryParse(str2, out dr2);
            if (isvaliddate)
            {
                Console.WriteLine(dr2);
            }
            else
                Console.WriteLine("not valied");

                Console.ReadKey();
            
        }
    }
}
