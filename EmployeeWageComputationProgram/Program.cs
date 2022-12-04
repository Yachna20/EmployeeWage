internal class Program
{
    static void Main(string[] args)
    {
        int fulltime = 1, Part_time = 2, Emp_Rate_Per_Hr = 20, empHrs = 0, empwage = 0;
        Random randobj = new Random();
        int checkPresent = randobj.Next(0, 3);
        Console.WriteLine("Random number" + checkPresent);
        if (checkPresent == fulltime)
        {
            empHrs = 8;

            Console.WriteLine("Employee is present");
        }
        else if (checkPresent == Part_time)
        {
            empHrs = 4;
            Console.WriteLine("Employee is present part-time");
        }
        else
        {
            empHrs = 0;

            Console.WriteLine("Employee is absent");
        }
        empwage = empHrs * Emp_Rate_Per_Hr;
        Console.WriteLine("Employee wage:" + empwage);
    }
}







