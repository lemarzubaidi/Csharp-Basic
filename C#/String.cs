using System;
using System.Security.Policy;
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "lemar zubaidi";
            Console.WriteLine(st.Length);
            Console.WriteLine(st.Substring(2,5));
            Console.WriteLine(st.ToLower());
            Console.WriteLine(st.ToUpper());
            Console.WriteLine(st[2]);
            Console.WriteLine(st.Insert(3,"KKKK"));
            Console.WriteLine(st.Replace("m","*"));
            Console.WriteLine(st.IndexOf("z"));
            Console.WriteLine(st.Contains("m"));
            Console.WriteLine(st.Contains("x"));
            Console.WriteLine(st.LastIndexOf("e"));

            string s2 = "Ali,Ahmed,Khaled";
            string[] namelist=s2.Split(',');
            Console.WriteLine(namelist[0]);
            Console.WriteLine(namelist[1]);
            Console.WriteLine(namelist[2]);

            string s3 = " zubaidi ";
            Console.WriteLine(s3.Trim());
            Console.WriteLine(s3.TrimStart());
            Console.WriteLine(s3.TrimEnd());
            // string interpolation 
            string fname = "lemar";
            string lname = "zubaidi";
            string code = "107";
            string fullname = $"Mr.{fname} {lname},code:{code} ";
            Console.WriteLine(fullname);
            Console.ReadKey();

        }
    }
}
