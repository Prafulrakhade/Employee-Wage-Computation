using System;

namespace ComputeEmpWageUsingClass
{
    public class Program
    {
        public static void  ComputeEmpWage()
        {
            int isPartTime = 0;
            int isPresent = 1;
            int isFullTime = 2;
            int result;
            int totalSalary;
            int salary;
            int empHrs = 0;
            int empRatePerHr = 20;
            int totalWorkingDays = 20;
            int totalWorkingHrs = 100;
            int workingHr = 0;
            int workingDays = 0;
            

            while(workingHr<=totalWorkingHrs || workingDays<=totalWorkingDays)
            {
                workingDays++;
                Random random = new Random();
                int randomCheck = random.Next(0, 3);
                switch(randomCheck)
                {
                    case 1:

                            Console.WriteLine("Employee is Part time : ");
                            empHrs = 4;
                            break;
                    case 2:

                            Console.WriteLine("Employee is full time : ");
                            empHrs = 8;
                            break;
                    default:

                            Console.WriteLine("Employee is Absent : ");
                            empHrs = 0;
                            break;
                        
                }
                workingHr = workingHr + empHrs;
            }
            totalSalary = workingHr * empRatePerHr;
            Console.WriteLine("Compute Employee Wage Using Class : "+totalSalary);
        }
         static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}
