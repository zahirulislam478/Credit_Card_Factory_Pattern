using MonthlyProject_FactoryPattern.Factories;
using MonthlyProject_FactoryPattern.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyProject_FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICardFacory f = new CreditCardFactory();
            TestClass tc = new TestClass(f);
            tc.Run();
            Console.ReadLine();

        }
    }
}
