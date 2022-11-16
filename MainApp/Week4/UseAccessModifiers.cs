using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MainApp.Week4.AccessModifiers;

namespace MainApp.Week4
{
    internal class UseAccessModifiers:MainClassAM
    {
        public static void mainUseMethodAM()
        {
            // private methods are no accessible from another class
            // MainClassAM.privateMethod();

            // to use protected method, inherit parent class containing protected method -- create its object -- then use method



            MainClassAM.internalMethod();
            MainClassAM.publicMethod();
        }
    }
}
