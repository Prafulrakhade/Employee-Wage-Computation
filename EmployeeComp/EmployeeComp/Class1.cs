using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComp
{
    public class Class1
    {
        int isPartTime = 0;
        int isPresent = 1;
        int isFullTime = 2;
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
        public void PartTime()
        {


            int randomCheck = random.Next(3);

            if (randomCheck == isPartTime)
            {
                Console.WriteLine("Employee work Half Day only");
                empHrs = 4;
            }
            else if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee work Full Day");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            Console.WriteLine("Todays Salary is : "+empRatePerHr * empHrs);
        }
        public void SwitchCase()
        {
            int randomCheck = random.Next(3);
            switch(randomCheck)
            {
                case 1:
                    empHrs = 8;
                    break;
                case 2:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            Console.WriteLine("By Switch Case salary is : "+empRatePerHr * empHrs);
        }
    }
}
