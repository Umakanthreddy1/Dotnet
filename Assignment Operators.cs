using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=2; int b=3;
            Console.WriteLine("a={0}",a);
            a += b;
            Console.WriteLine("a={0}", a);
            a -= b;
            Console.WriteLine("a={0}", a);
            a *= b;
            Console.WriteLine("a={0}", a);
            a /= b;
            Console.WriteLine("a={0}", a);

        }
    }
}
