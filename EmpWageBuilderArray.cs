using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_10
{
    public class EmpWageBuilderArray
    {
        public int isPartTime = 1;
        public int isFullTime = 2;

        private int numOfCompany=0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHrs, int totalWorkingDays, int totalWorkingHrs)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHrs, totalWorkingDays, totalWorkingHrs);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for(int i=0;i<numOfCompany;i++)
            {
                companyEmpWageArray[i].setToTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
         private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int workingDays = 0;
            int workingHrs = 0;

            while(workingHrs <= companyEmpWage.totalWorkingHrs && workingDays<companyEmpWage.totalWorkingDays)
            {
                workingDays++;
                Random random = new Random();
                int randomCheck = random.Next(0, 3);

                switch (randomCheck)
                {
                    case 1:

                        empHrs = 4;
                        break;

                    case 2:

                        empHrs = 8;
                        break;

                    default:

                        empHrs = 0;
                        break;
                }
                workingHrs = workingHrs + empHrs;
                Console.WriteLine("Days : " + workingDays + " Emp Hrs " + empHrs);
            }
            return workingHrs * companyEmpWage.empRatePerHrs;
        }
    }
}
