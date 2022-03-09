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
        Random random = new Random();
        public void Attendance()
        {
            int randomCheck = random.Next(2);
            if(randomCheck==isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
