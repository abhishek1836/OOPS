using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Quespond_Logics
{
    public class StaticMeaning
    {
        public static void abc()  //// static meaning
        {
            Console.WriteLine("abc");
            
        }

        public static void xyz()
        {
            abc();
        }
    }
}
