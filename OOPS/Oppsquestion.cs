using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class A
    {
        public virtual void Hello()
        {
            Console.WriteLine("A");
        }
    }

     class B : A
    {
       public override void Hello()
        {
            Console.WriteLine("B");
        }
    }



    class C : B
    {
        public override void Hello()
        {
            Console.WriteLine("C");
        }
    }

   
}
