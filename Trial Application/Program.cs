using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Actions.SayHello());
            Console.WriteLine(Actions.SayGoodbye());
            Console.ReadKey();
        }
    }
}
