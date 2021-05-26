using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int first = number / 100000;
            int second = (number / 10000) % 10;
            int third = (number / 1000) % 10;
            int fourth = (number / 100) % 10;
            int fifth = (number / 10) % 10;
            int sixth = number % 10;

            int firstHalf = first + second + third;
            int secondHalf = fourth + fifth + sixth;

            if(firstHalf == secondHalf)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();
        }
    }
}