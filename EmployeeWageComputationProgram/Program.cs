internal class Program
{
    static void Main(string[] args)
    {
        int fulltime = 1, Emp_Rate_Per_Hr = 20, empHrs = 0, empwage = 0;
        Random randobj = new Random();
        int checkPresent = randobj.Next(0, 2);
        Console.WriteLine("Random number" + checkPresent);
        if (checkPresent == fulltime)
        {
            empHrs = 8;

            Console.WriteLine("Employee is present");
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
    


