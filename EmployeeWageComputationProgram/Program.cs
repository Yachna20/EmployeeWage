namespace EmployeeWageComputationProgram;

 public class Program
 { 
    static void Main(string[] args)
    {
            EmployeeWage BigBasket = new EmployeeWage("BigBasket", 20, 20, 100);
            EmployeeWage Jio = new EmployeeWage("Jio", 40, 25, 100);
            BigBasket.computeEmpWage();
            Console.WriteLine(BigBasket.toString());
            Jio.computeEmpWage();
            Console.WriteLine(Jio.toString());

        }
  }



















