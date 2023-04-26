using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_computation
{
    public class Employee_check
    {
        public static void EmployeeAttendence()
        {

            int IS_FULL_TIME = 1;
            Random rdm = new Random();
            int empCheck = rdm.Next(2);
            if(empCheck == IS_FULL_TIME) 
            {
                Console.WriteLine("Employee Is present");
            }
            else 
            {
                Console.WriteLine("Employee Is absent");
            }
       }
    }
}
