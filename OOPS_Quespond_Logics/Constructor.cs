using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Quespond_Logics
{
    public class Constructor
    {

        int i; string s; bool b;
        //public Constructor() /// implicit constructor/default/ defined by compiler if we not create
        //{
        //    i = 0;
        //    s = null; 
        //    b = false; 
        //}
        //public Constructor(int i) // paramterized constructor
        //{
        //    Console.WriteLine(i);
        //}

        //static Constructor() // static cosntructor defined explicitly 
        //                     //A static constructor can not be a parameterized constructor.
        //{

        //}
        //static Constructor() //Within a class you can create only one static constructor.
        //{

        //}

        private Constructor(int i, string s, bool b) // paramterized constructor
        {

            Console.WriteLine(i);
        }

        public ~ Constructor (int i, string s, bool b) // paramterized constructor
        {

            Console.WriteLine(i);
        }
    }

    class abc
    {
        int i; string s; bool b;
        Constructor aa = new Constructor(); //If a class has one or more private constructor and no public constructor then other classes is not allowed to create instance of this class this
                                                 ////mean you can neither create the object of the class nor it can be inherit by other class.

    }
         class DCB : Constructor
    {
        
    }
   
    
}
