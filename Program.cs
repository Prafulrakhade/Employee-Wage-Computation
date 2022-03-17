using System;

namespace UC_9_SaveTotalWageEachCompany
{
    public class EmpWageObject
    {
        public int isPartTime = 1;
        public int isFullTime = 2;

        private string company;
        private int empRatePerHrs;
        private int totalWorkingDays;
        private int totalWorkingHrs;
        private int totalSalary;

        public EmpWageObject(string company, int empRatePerHrs, int totalWorkingDays, int totalWorkingHrs)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.totalWorkingDays = totalWorkingDays;
            this.totalWorkingHrs = totalWorkingHrs;
            
        }

        public void ComputeEmpWage()
        {
            int empHrs = 0;
            int workingDays = 0;
            int workingHrs = 0;

            while (workingHrs <= this.totalWorkingHrs && workingDays <= this.totalWorkingDays)
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
                workingHrs += empHrs;
                Console.WriteLine("days : " + workingDays + " Emp Hrs " + empHrs);
            }
            totalSalary = workingHrs * this.empRatePerHrs;
            Console.WriteLine("Total Employee Wage for Company : " + company + " is " + totalSalary);
        }
        public string toString()
        {
            return "Total Employee Wage for Company : " + this.company + " is " + this.totalSalary;
        }


        public static void Main(string[] args)
        {
            EmpWageObject TCS = new EmpWageObject("TCS", 20, 20, 100);//string company, int empRatePerHrs, int totalWorkingDays, int totalWorkingHrs
            EmpWageObject WIPRO = new EmpWageObject("WIPRO", 15, 20, 80);
            TCS.ComputeEmpWage();
            Console.WriteLine(TCS.toString());
            WIPRO.ComputeEmpWage();
            Console.WriteLine(WIPRO.toString());
        }
    }
}