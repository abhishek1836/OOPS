using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Employee_OpenClosePrinciple
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Employee_OpenClosePrinciple()  /// default constructor
        {

        }
        public Employee_OpenClosePrinciple(int id, string name) // parameterized constructor
        {
            this.EmployeeID = id;
            this.EmployeeName = name;
        }
        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID:{0} Name: {1}", this.EmployeeID, this.EmployeeName);
        }
    }

    public class permanentemp : Employee_OpenClosePrinciple
    {
        public permanentemp()
        {

        }
        public permanentemp(int EmployeeID, string EmployeeName) : base(EmployeeID, EmployeeName) //inherit base class properties
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {

            return salary * .1M;
        }
    }

    public class tempemp : Employee_OpenClosePrinciple
    {
        public tempemp()
        {

        }
        public tempemp(int EmployeeID, string EmployeeName) : base(EmployeeID, EmployeeName) //inherit base class properties
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {

            return salary * .05M;
        }
    }
}
