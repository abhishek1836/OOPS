using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test
{
    public class Class1
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 34, 342, 23, 1231, 213, 123, 213, 21321, 3, 123, 12, 3, 123, 12, 3, 213, 123, 1, 312, 3, 1, 312, 1, 3, 32242543, 645 };
            var arra = from i in arr where i > 40 select i;

            foreach (int i in arra)
            {
                Console.WriteLine(i);
            }

        }
    }
}
