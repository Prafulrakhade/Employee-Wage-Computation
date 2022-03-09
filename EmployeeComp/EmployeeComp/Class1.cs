using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComp
{
    public class Class1
    {
        int isPresent = 1;
        int empCheck;
        int result;
        int empHrs=1;
        int empRatePerHr = 20;

        Random random = new Random();
        public void Attendance()
        {
        int randomCheck = random.Next(2);

            if (randomCheck==isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void DailyWages()
        {
            int randomCheck = random.Next(2);
            if (randomCheck == isPresent)
            {
                empHrs = 8;
                result = empRatePerHr * empHrs;
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Employee Daily Wages =" + result);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Emmployee wage =0 ");
            }
        }
    }
}
