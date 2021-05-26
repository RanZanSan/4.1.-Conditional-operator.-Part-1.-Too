using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            bool c = true;
            bool d = false;

            Console.WriteLine((a > 5) && (b > 5) && (a < 20) && (b < 30));
            Console.WriteLine(c || d && (b == 20));
            Console.WriteLine(!(a < 15) || !(b < 30));
            Console.ReadKey();
        }
    }
}