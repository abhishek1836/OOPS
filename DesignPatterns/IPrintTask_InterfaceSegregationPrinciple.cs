using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
   // public interface IPrintTask_InterfaceSegregationPrinciple /// big interface class 
    //{

        interface IPrintTask
        {
            bool PrintContent(string content);
            bool ScanContent(string content);
            bool PhotoCopyContent(string content);
            
        }

        interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IPrintDuplex
    {
        bool PrintDuplexContene(string content); // new change create problems
    }
    
    }
//}
