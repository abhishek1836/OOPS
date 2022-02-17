using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Quespond_Logics
{
    public class Hiding
    {
        public void Show() // original method 
        {
            Console.WriteLine("This is parent class");
        }
    }
    public class ChildHiding :Hiding
    {
        public new void Show() ///  method hiding with new keyword
        {
            Console.WriteLine("This is child class");
        }
    }
}
