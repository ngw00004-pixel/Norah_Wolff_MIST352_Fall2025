using System.Security.Principal;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SHOWROOM MANAGEMENT SYSTEM ===\n");

            // three Car objects
            Console.WriteLine("--- CARS IN SHOWROOM ---");
            Car car1 = new Car();
            Car car2 = new Car("Toyota", "Camry");
            Car car3 = new Car("Honda", "Accord", 2023);

            car1.DisplayInfo();
            car2.DisplayInfo();
            car3.DisplayInfo();

            Console.WriteLine("\n--- EMPLOYEES ---");
            // three Employee objects
            Employee emp1 = new Employee();
            Employee emp2 = new Employee("Joe Smith");
            Employee emp3 = new Employee("Norah Wolff", 25.50, 38);

            emp1.DisplaySummary();
            emp2.DisplaySummary();
            emp3.DisplaySummary();

            Console.WriteLine("\n--- ACCOUNTS ---");
            // three Account objects
            Account acc1 = new Account();
            Account acc2 = new Account(1001, "John Smith");
            Account acc3 = new Account(1002, "Emily Davis", 5000.0);

            acc1.DisplayInfo();
            Console.WriteLine();

            acc2.DisplayInfo();
            acc2.Deposit(1500.0);
            Console.WriteLine();

            acc3.DisplayInfo();
            acc3.Withdraw(2000.0);
            acc3.Deposit(500.0);
            Console.WriteLine();

            Console.WriteLine("=== END OF REPORT ===");
            Console.ReadLine(); // Keeps console window open
        }
    }
}
