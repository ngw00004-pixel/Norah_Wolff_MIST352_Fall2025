/*Norah Wolff 
 * September 18
 * TASK 3 ask user for given number of items and collect each item
 */
using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Start
            Console.Write("How many items are in this order? ");
            string input = Console.ReadLine();

            int intItemCount;
            if (!int.TryParse(input, out intItemCount) || intItemCount <= 0)
            {
                Console.WriteLine("[Error] Invalid item count. Exiting...");
                return;
            }

           //DECLARE the arrays 
            string[]strNames = new string[intItemCount];
            double[] dblPrices = new double[intItemCount];
            int[] intQTYs = new int[intItemCount];
            int[] intStocks = new int[intItemCount];
            double[] dblLineTotals = new double[intItemCount];
            double[] dblLineDiscounts = new double[intItemCount];
            bool[] boolReorder = new bool[intItemCount];

            Console.ReadLine();
            Console.WriteLine("=== Mini POS: Enter item details === ");

            // loop for each item 
            // Fix for CS0103: The name 'i' does not exist in the current context
            // Move the item input code inside the for loop so 'i' is in scope

            for (int i = 0; i < intItemCount; i++)
            {
                Console.WriteLine($"\n=== Item #{i + 1} ===");

                // product name 
                Console.Write("Enter product name: ");
                strNames[i] = Console.ReadLine() ?? string.Empty; // Fix for CS8601: Possible null reference assignment.

                //unit price 
                Console.Write("Enter unit price (e.g., 12.50): ");
                string priceInput = Console.ReadLine();
                if (!double.TryParse(priceInput, out dblPrices[i]) || dblPrices[i] < 0)
                {
                    Console.WriteLine("[Warn] Invalid price. Defaulting to 0");
                    dblPrices[i] = 0;
                }

                // Quantity 
                Console.Write("Enter quantity (integer): ");
                string QTYsInput = Console.ReadLine();
                if (!int.TryParse(QTYsInput, out intQTYs[i]) || intQTYs[i] < 0)
                {
                    Console.WriteLine("[Warn] Invalid quantity. Defaulting to 0");
                    intQTYs[i] = 0;
                }

                // Stock on hand 
                Console.Write("Enter stock on hand (integer): ");
                string stockInput = Console.ReadLine();
                if (!int.TryParse(stockInput, out intStocks[i]) || intStocks[i] < 0)
                {
                    Console.WriteLine("[Warn] Invalid stock. Defaulting to 0");
                    intStocks[i] = 0;
                }

                // Business rules 
                double dblGross = dblPrices[i] * intQTYs[i];
                dblLineDiscounts[i] = (intQTYs[i] >= 10) ? dblGross * 0.05 : 0;
                dblLineTotals[i] = dblGross - dblLineDiscounts[i];

                //Reorder Check 
                int intPostSalesStock = intStocks[i] - intQTYs[i];
                boolReorder[i] = intPostSalesStock < 5;
            }
                
                //Totals 
                double dblSubtotal = 0; 
                for (int k = 0; k < intItemCount; k++)
                {
                    dblSubtotal += dblLineTotals[k];
                }
                double dblTax = dblSubtotal * 0.06;
                double dblGrand = dblSubtotal +dblTax;
                
                //Output 
                Console.WriteLine ("\n==Order Summary ==");
                Console.WriteLine(" Name        Price       Qty    Gross    Disc     line    Total   Reorder");
                Console.WriteLine("-------------------------------------------------------------------------");

                for (int k = 0; k < intItemCount; k++)
                {
                    double gross = dblPrices[k] * intQTYs[k]; 
                    string reorderText = boolReorder[k] ? "YES" : "NO";
                    Console.WriteLine($"{strNames[k],-12}{dblPrices[k],7:F2}{intQTYs[k],8}{gross,10:F2}{dblLineDiscounts[k],9:F2}{dblLineTotals[k],13:F2}{reorderText,11}");
                }

                Console.WriteLine($"\nSubtotal: {dblSubtotal:F2}");
                Console.WriteLine($"Tax (6%): {dblTax:F2}");
                Console.WriteLine($"GRAND TOTAL: {dblGrand:F2}");

                Console.WriteLine("\nDone. Press Enter to exit..");
                Console.ReadLine();
            














        }
    }
}
