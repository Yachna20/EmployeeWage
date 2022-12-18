class Program
{
    public const int part_time = 1;
    public const int Full_time = 2;
    public static int computeEmpWage(string company, int empRatePerHr, int NoOfWorkingDays, int maxHrsPerMonth)
    {
        int empHrs = 0;
        int totalWorkingDays = 0;
        int totalEmpHrs = 0;
        while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < NoOfWorkingDays)
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

        int totalEmpWage = totalEmpHrs * empRatePerHr;
        Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        return totalEmpWage;
    }
    static void Main(string[] args)
    {
        computeEmpWage("Infosys", 20, 20, 100);
        computeEmpWage("Reliance", 40, 25, 100);
    }
}






















