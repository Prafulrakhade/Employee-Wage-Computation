using System;

namespace UC_10
{
    public class CompanyEmpWage
    {

        public string company;
        public int empRatePerHrs;
        public int totalWorkingDays;
        public int totalWorkingHrs;
        public int totalSalary;

        public CompanyEmpWage(string company, int empRatePerHrs, int totalWorkingDays, int totalWorkingHrs)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.totalWorkingDays = totalWorkingDays;
            this.totalWorkingHrs = totalWorkingHrs;
        }

        public void setToTotalEmpWage(int totalEmpWage)
        {
            this.totalSalary = totalSalary;
        }

        public string toString()
        {
            return "Total Emp Wage For Company : " + this.company + " is  " + this.totalSalary;
        }
    }
}
