using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week2
{
    internal class SelectStatement
    {
        public static void IfElse(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }

            else if(num1 < num2)
            {
                Console.WriteLine($"{num1} is smaller than {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is equal {num2}");
            }
        }
    }
}
