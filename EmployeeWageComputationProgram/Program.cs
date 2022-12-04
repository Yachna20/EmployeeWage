class Program
{
    public const int part_time = 1;
    public const int Full_time = 2;
    public const int Emp_Rate_Per_Hr = 20;
    static void Main(string[] args)
    {
        int empHrs = 0;
        int empwage = 0;
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
        empwage = empHrs * Emp_Rate_Per_Hr;
        Console.WriteLine("Employee wage:" + empwage);
    }
}

















