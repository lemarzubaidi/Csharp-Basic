using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte
            byte b1 = 255;
            sbyte b2 = -128;
            Console.WriteLine("\n byte:");
            Console.WriteLine("min={0} , max={1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("min={0} , max={1}", sbyte.MinValue, sbyte.MaxValue);
            //short
            short s1 = -32768;
            short s2 = 32767;
            ushort s3 = 65535;
            Console.WriteLine("\n short:");
            Console.WriteLine("min={0} , max={1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("\n ushort:");
            Console.WriteLine("min={0} , max={1}", UInt16.MinValue, UInt16.MaxValue);
            //int
            int i = -2147483648;
            int j = 2147483647;
            uint k = 4294967295;
            Console.WriteLine("\n int:");
            Console.WriteLine("min={0} , max={1}", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("\n uint:");
            Console.WriteLine("min={0} , max={1}", UInt32.MinValue, UInt32.MaxValue);
            //long
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;
            ulong ul1 = 18223372036854775808ul;
            Console.WriteLine("\n long:");
            Console.WriteLine("min={0} , max={1}", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("\n ulong:");
            Console.WriteLine("min={0} , max={1}", UInt64.MinValue, UInt64.MaxValue);
            //float
            float f1 = 123456.5f;
            float f2 = 1.123456f;
            Console.WriteLine("\n float:");
            Console.WriteLine("min={0} , max={1}", float.MinValue, float.MaxValue);
            //double
            double d1 = 123456789123456.5d;
            double d2 = 1.123456789123456d;
            Console.WriteLine("\n double:");
            Console.WriteLine("min={0} , max={1}", double.MinValue, double.MaxValue);
            //decimal
            decimal d3 = 123456789123456789123456789.5m;
            decimal d4 = 1.123456789123456789123m;
            Console.WriteLine("\n decimal:");
            Console.WriteLine("min={0} , max={1}", decimal.MinValue, decimal.MaxValue);

            //
            double d = 0.12e2;
            Console.WriteLine(d);

            float f= 123.45e-2f;
            Console.WriteLine(f);

            decimal m = 1.2e6m;
            Console.WriteLine(m);

            //hex&binary
            int hex = 0x2F;
            int binary = 0b_0010_1000;
            Console.WriteLine(hex);
            Console.WriteLine(binary);
            

            //default
            int i9 = default(int);
            float f9= default(float);
            decimal d9= default;
            bool b9= default;
            char c9= default;
            Console.WriteLine(c9+"\n");
            Console.WriteLine(d9+"\n");
            Console.WriteLine(b9+"\n");
            Console.WriteLine(i9+"\n");
            Console.WriteLine(f9+"\n");

            Console.ReadKey();

        }
    }
}
