using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Quespond_Logics

    //When do you use Abstract Class?
 //When you have a requirement where your base class should provide the default implementation of certain methods whereas other methods should be 
    //open to being overridden by child classes that time you have to use abstract classes.
{
    public abstract  class Customer  // abstract and sealed or static can`t be used togethor as they are 
                                    //contradiction
    {
        public string name { get; set; }
        public int phnumber { get; set; }

        public string productname { get; set; }

        public decimal productdiscount { get; set; }

        public abstract decimal Calculatediscount();

        public  virtual void test()
        {

        }

        //public void Customer()   //// Can abstract class have Constructors in C#? NO
        //{

        //}

    }
    public class GoldCustomer :Customer
    {
        public override decimal Calculatediscount()
        {
            return productdiscount - 10;
        }

        public override void test() // abstract method and virtual method can only overridden by derived class
        {

        }
    }
    public class SilverCustomer : Customer // Does Abstract class support multiple Inheritance? NOT POSSIBLE
    {
        public override decimal Calculatediscount()
        {
            return productdiscount - 5;
        }
    }
}


//In abstract class, Can non abstract method be overridden in derived class ?