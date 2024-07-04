using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Vsia;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visa.Visa visa = new Visa.Visa();
            string[] resourceList = visa.FindResource("DSA");
            bool isOk = visa.Open(resourceList);
            Console.WriteLine();
        }
    }
}
