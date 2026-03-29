using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        struct ststudent
        {
            public string firstname;
            public string lastname;
        }
        static void Main(string[] args)
        {
            //struct
            ststudent student;
            ststudent student2=new ststudent();
            student.firstname="lemar";
            student.lastname = "zubaidi";
            Console.WriteLine(student.firstname);
            Console.WriteLine(student.lastname);
            student2.lastname = "zubaidi";
            student2.firstname = "diyar";
            Console.WriteLine(student2.lastname);
            Console.WriteLine(student2.firstname);

            // dynamic
            dynamic dynamicvar = 100;
            Console.WriteLine("value:{0}, type:{1}",dynamicvar,dynamicvar.GetType());
            dynamicvar = true;
            Console.WriteLine("value:{0}, type:{1}", dynamicvar, dynamicvar.GetType());
            dynamicvar = DateTime.Now;
            Console.WriteLine("value:{0}, type:{1}", dynamicvar, dynamicvar.GetType());
            Console.ReadKey();
        }
    }
}
