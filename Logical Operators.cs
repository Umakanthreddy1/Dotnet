using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 20;
            Console.WriteLine(a>b && a<b);
            Console.WriteLine(a>b == a<b);
            Console.WriteLine(a>b || a<b);
            Console.WriteLine(a>b != a<b);
            bool c=true;
            Console.WriteLine(!c);

        }
    }
}
