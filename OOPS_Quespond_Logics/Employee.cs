using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPS_Quespond_Logics
{
    public class Employee
    {
        public string Name { get; set; }
        public string address { get; set; }

        public void Validate() // want to show it i.e. hiding inside functions and
                               // show only validate that is abstraction
        {
            Checkname();
            Checkaddress();
        }

        private void Checkname() // don`t want to show it 
        {
            if (Name != null)
            {

            }
        }

        public void Checkaddress() // don`t want to show it 
        {
            if (address != null)
            {

            }
        }

        public virtual void Test() // virtual keyword/virtual method
        {
            //somelogic
        }

            }

    public class Manager : Employee // manager is child and employee is parent/base 
                                    // inheritance_happening
    {

        Employee e1 = new Employee();
        // e1. Are private class members inherited to the derived class?
        //Yes, the private members are also inherited in the derived class but we will not be able to access them.
       // Trying to access a private base class member in the derived class will report a compile time error.


        public void management()
        {
            //somecode
        }
        public override void Test() // overriding / method overriding // only public method can be overriden
        {
            //somenewlogic
        }


        //Same parameter with different return type we cannot overload a method.
        //But
        //With different parameter and different return type we can overload a method

        public void Test(bool strict) // overloading of overriden fuction
                                              //  method overloading 
        {
            //somenewlogic
        }
        public void Test(bool strict, int m) // agin overloading of overloading
                                                     // fuction
                                                     // method overloading 
        {
            //somenewlogic
        }

        public string Test( int m, bool strict) // 

        {
            string a = "";
            return a;

        } // agin overloading of overloading
    }

    public class Supervisor : Employee
    {

    }

    public class someclass
    {
        private int somevalue;
        public someclass(int v)
        {
            somevalue = v;
        }

        public static someclass operator +(someclass arg1, someclass arg2)
        {
            return new someclass(arg1.somevalue + arg2.somevalue);
        }
    }
}


