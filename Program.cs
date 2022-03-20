using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("TCS", 20, 20, 100);
            empWageBuilder.addCompanyEmpWage("Wipro", 15, 20, 80);
            empWageBuilder.computeEmpWage();
        }
    }
}
