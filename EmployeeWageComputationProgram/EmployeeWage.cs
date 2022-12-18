using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    internal class EmployeeWage
    {
        
        public const int part_time = 1;
        public const int Full_time = 2;
        private string company;
        private int empRatePerHr;
        private int totalEmpWage;
        private int NoOfWorkingDays;
        private int maxHrsPerMonth;
        public EmployeeWage(string company, int empRatePerHr, int NoOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.NoOfWorkingDays = NoOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.NoOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case part_time:
                        empHrs = 4;
                        break;
                    case Full_time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }

            totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
           
        }
        public string toString()
        {
            return "Total Emp Wage for Company :" + this.company + " is: " + totalEmpWage;
        }
        
        
    }
}
