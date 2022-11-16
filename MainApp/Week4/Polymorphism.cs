using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week4
{
    internal class Polymorphism
    {
        //is the ability of objects of different types to provide a unique interface for different implementations of
        //methods.It is usually used in the context of late binding,
        //where the behavior of an object to respond to a call to its method members is determined based on
        //object type at run time.

        /*Compile time Polymorphism
         * Method Overloading => methods with same name, with different types and numbers of params
         * Operator Overloading => operators behaving differently with different operands (Like : +)
        */

        /*Runtime Polymorphism
         * Method Overridng => if the same method is present in both the superclass and the subclass. 
         *                  Then, the method in the subclass overrides the same method in the superclass.
         * 
         */

        public void overloadingExample(int x, int y)
        {
            Console.WriteLine($"The result is: { x + y}");
        }

        public void overloadingExample(string x, string y)
        {
            Console.WriteLine($"The result is: { x + y}");
        }

        public virtual void overrideMethod()
        {
            Console.WriteLine("Hi! I am from base/parent class.");
        }


        public class ChildClass : Polymorphism
        {
            // Overrding method overrideMethod()
            public override void overrideMethod()
            {
                Console.WriteLine("Hi! I am from derived/child class.");
            }
        }

        public class MainClass
        {
             public static void mainMethod()
            {
                ChildClass child1 = new ChildClass();

                child1.overloadingExample(2, 3);

                child1.overloadingExample("2", "3");

                child1.overrideMethod();
            }
        }
    }
}
