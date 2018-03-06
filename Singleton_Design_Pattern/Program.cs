using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
            
            Singleton s2 = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Student");
        }
    }
}
