using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns
{
    class Program { 
        static void Main(string[] args)
        {
            //Singleton s1 = new Singleton(); // creating instance only one time
            //Singleton s2 = new Singleton();      // but using it for printing diffrent message 
            Singleton s1 = Singleton.GetInstance;
            Singleton s2 = Singleton.GetInstance;
            s1.PrintDetails("This is first message");
            s2.PrintDetails("This is second message");
            Console.ReadLine();

            Employee_OpenClosePrinciple a = new Employee_OpenClosePrinciple(1,"john");
            string value = a.ToString();
            Console.WriteLine(String.Format("Employee{0} Bonus :{1}",
            a.ToString(),
            a.CalculateBonus(10000).ToString()));
            Console.ReadLine();
        }
    }
}