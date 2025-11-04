using System.Security.Principal;
/* to get this exact program I told chat gpt to ...
 * Create a visual studio program with the following requirements:

1. Car Class:
   - Private fields: make (String), model (String), year (int)
   - Three constructors:
       * Default constructor that sets generic values
       * Constructor with make and model (uses current year)
       * Constructor with make, model, and year
   - Getters and setters for all fields
   - DisplayInfo() method to print car details

2. Employee Class:
   - Private fields: name (String), hourlyRate (double), hoursPerWeek (int)
   - Three constructors:
       * Default constructor with "New Hire" and default pay values
       * Constructor with name only (default pay)
       * Constructor with name, rate, and hours
   - Getters and setters for all fields
   - DisplaySummary() method to show name and calculated annual salary

3. Account Class:
   - Private fields: accountNumber (int), ownerName (String), balance (double)
   - Three constructors:
       * Default constructor with unknown owner and zero balance
       * Constructor with account number and owner (zero balance)
       * Constructor with all three fields
   - Getters and setters for all fields
   - Deposit(double amount): adds to balance if positive
   - Withdraw(double amount): deducts if funds are available (no overdraft)
   - DisplayInfo() method to show account details

4. Main Class:
   - Creates three objects from each class
   - Displays all their information
   - Demonstrates deposit and withdraw methods
---------------------------------------------------------------



- ChatGPT’s DisplayInfo() and DisplaySummary() methods used string interpolation ($"...")
- mine used Console.WriteLine() statements separately for each line.
- I used simpler calculations for employee annual salary, while ChatGPT formatted it with rounding and currency.
- I manually validated or assigned default values inside constructors.
-ChatGPT’s constructors were slightly more concise, sometimes using this()
*/
s
namespace Task6_GPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Car objects
            Car car1 = new Car();
            Car car2 = new Car("Toyota", "Camry");
            Car car3 = new Car("Ford", "Mustang", 2020);

            // Display car info
            car1.DisplayInfo();
            car2.DisplayInfo();
            car3.DisplayInfo();

            // Create Employee objects
            Employee emp1 = new Employee();
            Employee emp2 = new Employee("Alice");
            Employee emp3 = new Employee("Bob", 25.50, 35);

            // Display employee summaries
            emp1.DisplaySummary();
            emp2.DisplaySummary();
            emp3.DisplaySummary();

            // Create Account objects
            Account acc1 = new Account();
            Account acc2 = new Account(1001, "Alice");
            Account acc3 = new Account(1002, "Bob", 500.0);

            // Display account info
            acc1.DisplayInfo();
            acc2.DisplayInfo();
            acc3.DisplayInfo();

            // Demonstrate deposit and withdraw
            acc3.Deposit(200.0);
            acc3.Withdraw(100.0);
            acc3.Withdraw(700.0); // should show insufficient funds
            acc3.DisplayInfo();
        }
    }
    }
