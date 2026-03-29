using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        //enums
        enum enweekdays
        {
            monday,
            tusday,
            wenesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        enum encategories
        {
            electronics,
            food,
            automotive=6,
            arts,
            beautycare,
            fashion
        }
        enum encategories2 : byte
        {
            electronics=1,
            food=5,
            automotive=6,
            arts=10,
            beautycare=11,
            fashion=15
        }
        static void Main(string[] args)
        {
            enweekdays weekdays;
            weekdays = enweekdays.friday;
            Console.WriteLine(weekdays);
            //nullable
            Nullable<int> i = null;
            Console.WriteLine(i);
            //read only datatype 
            var student = new {id=20,firstname="lemar",lastname="zubaidi" };
            Console.WriteLine("\nexample1:");
            Console.WriteLine(student.id);
            Console.WriteLine(student.firstname);
            Console.WriteLine(student.lastname);
            Console.WriteLine(student);
            var student2 = new
            {
                id = 30,
                firstname = "jamal",
                lastname = "zubaidi"
                ,
                adress = new { id = 1, city = "tulkarm", country = "palestine" }
            };
            Console.WriteLine("\nexample2:");
            Console.WriteLine(student2.id);
            Console.WriteLine(student2.firstname);
            Console.WriteLine(student2.lastname);
            Console.WriteLine(student2.adress.id);
            Console.WriteLine(student2.adress.city);
            Console.WriteLine(student2.adress.country);
            Console.WriteLine(student2.adress);



            Console.ReadKey();

        }
    }
}
