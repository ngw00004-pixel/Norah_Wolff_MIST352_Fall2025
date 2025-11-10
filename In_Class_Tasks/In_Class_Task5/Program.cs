using System.ComponentModel;

namespace In_Class_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Tip & Tax Splitter Pro ===");
            Console.Write("We'll total a fixed order, add tax, add tip, and split the bill.");
            Console.WriteLine("Enter tax/tip as decimals (e.g., 0.07 = 7%, 0.18 = 18%).");
            Console.WriteLine("Finally, we divide by the number of people.");

            // fixed subtotal 
            double subtotal = 59.99;

            //input 
            Console.WriteLine();
            Console.Write("Tax rate (decimal,e.g. 0.07): ");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            Console.Write ("Tip rate (decimal,e.g. 0.18): ");
            double tipRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many people? ");
            int numPeople = Convert.ToInt32(Console.ReadLine());

            //Calculations
            double withTax = subtotal * (1 + taxRate);
            double withTaxTip = withTax * (1 + tipRate);
            double perPerson = withTaxTip / numPeople;

            //Output
            Console.WriteLine($"\n[SUBTOTAL] ${subtotal:F2}");
            Console.WriteLine($"[WITH_TAX] ${withTax:F2}");
            Console.WriteLine($"[WITH_TAX_TIP] ${withTaxTip:F2}");
            Console.WriteLine($"[PER_PERSON] ${perPerson:F2}");
            Console.WriteLine("=== Done ===");






        }
    } 
}
