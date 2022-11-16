using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week4
{
    internal class AccessModifiers
    {
        public class MainClassAM
        {
            private static void privateMethod()
            {
                Console.WriteLine("This is private method.");
            }

            protected virtual void protectedMethod()
            {
                Console.WriteLine("This is protected method.");
            }

            internal static void internalMethod()
            {
                Console.WriteLine("This is internal method.");
            }

            public static void publicMethod()
            {
                Console.WriteLine("This is private method.");
            }
        }
    }
}
