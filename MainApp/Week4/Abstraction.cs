using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week4
{
    public abstract class Abstraction
    {
        public abstract string printName(string name);
    }

    public class Details : Abstraction
    {
        // Overriding the method inside abstract class
        public override string printName(string name)
        {
            Console.Write("Hello! My name is ");
            return name;
        }

    }

    public class CallName
    {
        public static void mainMethod()
        {
            Details detail1= new Details();
            string result = detail1.printName("Ashma Maharjan");
            Console.WriteLine(result);
        }
    }
}
