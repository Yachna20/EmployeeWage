internal class Program
{
    static void Main(string[] args)
    {
        int fulltime = 1;
        Random randobj = new Random();
        int checkPresent = randobj.Next(0, 2);
        Console.WriteLine("Random number" + checkPresent);
        if (checkPresent == fulltime)
        {

            Console.WriteLine("Employee is present");
        }
        else
        {

            Console.WriteLine("Employee is absent");
        }
    }
}

