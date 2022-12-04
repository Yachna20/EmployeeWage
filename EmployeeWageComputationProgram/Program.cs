class Program
{
    public const int part_time = 1;
    public const int Full_time = 2;
    public const int Emp_Rate_Per_Hr = 20;
    public const int No_Of_Working_Days = 20;
    static void Main(string[] args)
    {
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        for (int day = 0; day < No_Of_Working_Days; day++)
        {
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
            empWage = empHrs * Emp_Rate_Per_Hr;
            totalEmpWage += empWage;
            Console.WriteLine("Employee wage:" + empWage);
        }
        Console.WriteLine("Total Emp Wage : " + totalEmpWage);



    }
}





















