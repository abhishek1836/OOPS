using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    
    public sealed class Singleton // sealed restricts the inheritance 
    {
        private static int counter = 0;
        private static Singleton instance = null; // public property is used to return only
                                                  // one instantiated
                                                  // of the class itself
        public static Singleton GetInstance // public property is used to return only one
                                            // instance of the class leveraging on the private property
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        public Singleton() // private constucture  ensures that object is
                           // not instanctiated other than with in the class itselt. 
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message) // private method which can be invoked through
                                                 // the singleton instance
        {
            Console.WriteLine(message);
        }
    }
}
