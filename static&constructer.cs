using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }

        public string Password { get; set; }

        public clsPerson(int id, string name, short age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public static clsPerson Find(int id)
        {
            if (id == 10)
            {
                return new clsPerson(10, "Mohammed Abu Hadhoud", 45);
            }
            else
                return null;

        }

        public static clsPerson Find(string Username, string Password)
        {
            if (Username == "user1" && Password == "p1234")
                return new clsPerson(10, "Mohammed Abu Hadhoud", 45);
            else
                return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Person1 y ID");
            clsPerson person1 = clsPerson.Find(10);
            if (person1 != null)
            {
                Console.WriteLine("ID:={0}", person1.Id);
                Console.WriteLine("Name:={0}", person1.Name);
                Console.WriteLine("Age:={0}", person1.Age);
            }
            else
            {
                Console.WriteLine("Could Not find the person by the givin ID");

            }
            Console.WriteLine("\nFinding Person2 y ID");
            clsPerson person2 = clsPerson.Find("user1", "p1234");
            if (person2 != null)
            {
                Console.WriteLine("ID:={0}", person2.Id);
                Console.WriteLine("Name:={0}", person2.Name);
                Console.WriteLine("Age:={0}", person2.Age);
            }
            else
            {
                Console.WriteLine("Could Not find the person by the givin ID");

            }


        }

    }

}