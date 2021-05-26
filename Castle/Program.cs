using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            if((x1 != x2) && (y1 != y2))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            Console.ReadKey();
        }
    }
}