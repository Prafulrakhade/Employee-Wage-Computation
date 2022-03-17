using System;

namespace UC_8_MultipleCompany
{
    
    public  class Program
    {
        int isPartTime = 1;
        int isFullTime = 2;
        public static int MultipleCom(string company, int empRatePerHrs,  int TotalWorkingHrs, int TotalWorkingDays)
        {
            int empHrs = 0;
            int workingHrs = 0; 
            int workingDays = 0;
            int totalSalary = 0;

            while (workingHrs<=TotalWorkingHrs || workingDays<=TotalWorkingDays)
            {
                workingDays++;
                Random random = new Random();
                int randomCheck = random.Next(0, 3);
                switch(randomCheck)
                {
                    case 1:

                        Console.WriteLine("Employee is PartTime: ");
                        empHrs = 4;
                        break;

                    case 2:

                        Console.WriteLine("Employee is FullTime : ");
                        empHrs = 8;
                        break;

                    default:

                        Console.WriteLine("Employee is Absent : ");
                        empHrs = 0;
                        break;
                }
                workingHrs = workingHrs + empHrs;
            }
            totalSalary = workingHrs * empRatePerHrs;
            Console.WriteLine(company+" Total Salary is : "+totalSalary);
            return totalSalary;
        }
        static void Main(string[] args)
        {
            MultipleCom("TCS", 20, 100, 20); // company name, empRatePerHrs, totalWorkingHrs, totalWorkingDays
            MultipleCom("Wipro", 25, 80, 20);
            MultipleCom("IBM", 15, 50, 10);
        }
    }
}
