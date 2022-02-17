using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS_Quespond_Logics;

namespace OOPS
{
    public sealed class Class1 /// sealed class created and cannot be inherited
    {

        Patients a = new Patients();
    }

    public class Class2 : Class1
    { 
    }
}
