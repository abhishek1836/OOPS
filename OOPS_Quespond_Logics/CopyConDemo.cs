using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Quespond_Logics
{
    public class CopyConDemo
    {
        int x;

        
        public CopyConDemo(int i) // normal cosntructor
        {
            x = i;
        }
        public CopyConDemo(CopyConDemo obj) // copy constructor :- multiple isntance of same value
        {
            x = obj.x;
        }
        public void dispaly()
        {
            Console.WriteLine(x);
        }
    }
}
