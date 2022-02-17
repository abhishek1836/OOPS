using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Quespond_Logics
{

    // interface is used to get maximum abstraction
    //Extensibility
    //Implementation Hiding
   //Accessing object using interfaces
    //Loose coupling
    // we dont have any body interface method and abstract method


    //public class Inter : ILogics //  The reason interfaces only provide declarations
    //is because they are inherited by structs and classes,
    //which must provide an implementation for each interface member declared.
    //{

    //}

    public interface ILogics /// making contract between ILogics and Customer1
    {

        string name { get; set; }
        int phnumber { get; set; }

        string productname { get; set; }

        decimal productdiscount { get; set; }

        decimal Calculatediscount(int a);
        //decimal Calculatediscount(int a,string b);
    }

    public interface ILogics_Logic : ILogics /// new interface for new logic
    {
        Decimal Calculateintered(); // new method
    }
    public abstract class Customer1 : ILogics, ILogics_Logic ///multiple inheritance
    {
        public string name { get; set; }
        public int phnumber { get; set; }

        public string productname { get; set; }

        public decimal productdiscount { get; set; }

        public abstract decimal Calculatediscount(int a);

        public decimal Calculateintered()
        {
            return 0;
        }
    }
    public class GoldCustomer1 : Customer1
    {
        public override decimal Calculatediscount()
        {
            return productdiscount - 10;
        }
    }
    public class SilverCustomer1 : Customer1
    {
        public override decimal Calculatediscount()
        {
            return productdiscount - 5;
        }
    }
}
