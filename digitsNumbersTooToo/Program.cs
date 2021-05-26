using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitsNumbersTooToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int numberOne = (number / 10) / 10;
            int numberTwo = (number / 10) % 10;
            int numberThree = number % 10;

            if (numberOne == numberTwo || numberOne == numberThree || numberTwo == numberThree)
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