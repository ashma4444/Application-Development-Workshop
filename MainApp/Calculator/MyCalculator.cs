using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Calculator
{
    internal class MyCalculator
    {
        public void Calc()
        {
            Console.WriteLine("Enter first num: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second num: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var add = num1 + num2;

            Console.WriteLine($"Result: {add}");
        }
    }
}
