using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Quespond_Logics
{
   public class Patients // real world object
    {
        public string name { get; set; }
        public string address { get; set; }

        public Doctors docallocated { get; set; } // linking doctors class object   

    }

    class Doctors
    {
        public string name { get; set; }
    }
}
