using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Quespond_Logics
{

    // The main purpose of a sealed class is to take away the inheritance feature from the
    // class users so they cannot derive a class from it.
    // One of the best usage of sealed classes is when you have a class with static members. 
    public sealed class SealedClass // to stop inheritance

        
    {

        public  int Test(int ab)
        {
            int a = 12;
            return a;
        }

    }

  class Asdas
    {
        public void abc() //we can access sealed in any other class with any method defined by created object 
        {
            SealedClass az = new SealedClass(); 
             az.Test(12);
           
        } 
    }



}
