class Program
{
    public const int part_time = 1;
    public const int Full_time = 2;
    public const int Emp_Rate_Per_Hr = 20;
    public const int No_Of_Working_Days = 20;
    public const int Max_Hrs_In_Month = 100;
    static void Main(string[] args)
    {
        int empHrs = 0;
        
        int totalEmpWage = 0;
        int totalWorkingDays = 0;
        int totalEmpHrs = 0;
        while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < No_Of_Working_Days)
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
         totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hr;
        Console.WriteLine("Total Employee Wage: " + totalEmpWage);
    }
}





















