using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week3
{
    internal class OddEven
    {
        public static void checkOddEven()
        {
            Console.WriteLine("Enter a number:");
            var num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number.");
            }

            else
            {
                Console.WriteLine($"{num} is an odd number.");
            }
        }
    }
}
