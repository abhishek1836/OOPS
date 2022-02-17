using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns // Implementation of Single Responsibilty Principle
{
    interface IUser_SingleResponsibiltyPrinciple  // user responsibility
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }
    interface ILogger // error logger
    {
        void LogError(string error);
    }
    interface IEmail // send email
    {
        bool SendEmail(string emailcontent);
    }
}
