
/*Author: Norah Wolff 
 *Class: MIST- FALL2025
 * HW 1
 *This program prompts the user to enter information for four products. It then calculates the total price for each product based on the quantity and price, and displays a formatted
 */
using System;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DEfine variables for product 1 
            string strProduct1Name, strProduct1Category;
            int intProduct1SerialNumber, intProduct1Quantity;
            double dblProduct1Price, dblProduct1TotalPrice;

            // Get product 1 info

            Console.WriteLine("Enter information for product #1");

            Console.Write("Product name: ");
            strProduct1Name = Console.ReadLine();

            Console.Write("Product serial number (numbers only) : ");
            intProduct1SerialNumber = int.Parse(Console.ReadLine());

            Console.Write("Product price: ");
            dblProduct1Price = Double.Parse(Console.ReadLine());

            Console.Write("Product quantity: ");
            intProduct1Quantity = int.Parse(Console.ReadLine());

            Console.Write("Product Category: ");
            strProduct1Category = Console.ReadLine();

            // Calculate total price for product 1 
            dblProduct1TotalPrice = intProduct1Quantity * dblProduct1Price;

            Console.WriteLine();// Blank line for spacing

            // DEfine variables for product 2
            string strProduct2Name, strProduct2Category;
            int intProduct2SerialNumber, intProduct2Quantity;
            double dblProduct2Price, dblProduct2TotalPrice;

            // Get product 2 info

            Console.WriteLine("Enter information for product #2");

            Console.Write("Product name: ");
            strProduct2Name = Console.ReadLine();

            Console.Write("Product serial number (numbers only): ");
            intProduct2SerialNumber = int.Parse(Console.ReadLine());

            Console.Write("Product price: ");
            dblProduct2Price = Double.Parse(Console.ReadLine());

            Console.Write("Product quantity: ");
            intProduct2Quantity = int.Parse(Console.ReadLine());

            Console.Write("Product Category: ");
            strProduct2Category = Console.ReadLine();

            // Calculate total price for product 2 
            dblProduct2TotalPrice = intProduct2Quantity * dblProduct2Price;

            Console.WriteLine();// Blank line for spacing

            //DEfine variables for product 3
            string strProduct3Name, strProduct3Category;
            int intProduct3SerialNumber, intProduct3Quantity;
            double dblProduct3Price, dblProduct3TotalPrice;

            //Get product 3 info

            Console.WriteLine("Enter information for product #3");

            Console.Write("Product name: ");
            strProduct3Name = Console.ReadLine();

            Console.Write("Product serial number (numbers only): ");
            intProduct3SerialNumber = int.Parse(Console.ReadLine());

            Console.Write("Product price: ");
            dblProduct3Price = Double.Parse(Console.ReadLine());

            Console.Write("Product quantity: ");
            intProduct3Quantity = int.Parse(Console.ReadLine());

            Console.Write("Product Category: ");
            strProduct3Category = Console.ReadLine();

            // Calculate total price for product 3
            dblProduct3TotalPrice = intProduct3Quantity * dblProduct3Price;

            Console.WriteLine();// Blank line for spacing

            //DEfine variables for product 4
            string strProduct4Name, strProduct4Category;
            int intProduct4SerialNumber, intProduct4Quantity;
            double dblProduct4Price, dblProduct4TotalPrice;

            //Get product 4 info

            Console.WriteLine("Enter information for product #4");

            Console.Write("Product name: ");
            strProduct4Name = Console.ReadLine();

            Console.Write("Product serial number (numbers only): ");
            intProduct4SerialNumber = int.Parse(Console.ReadLine());

            Console.Write("Product price: ");
            dblProduct4Price = Double.Parse(Console.ReadLine());

            Console.Write("Product quantity: ");
            intProduct4Quantity = int.Parse(Console.ReadLine());

            Console.Write("Product Category: ");
            strProduct4Category = Console.ReadLine();


            // Calculate total price 4
            dblProduct4TotalPrice = intProduct4Quantity * dblProduct4Price;

            Console.WriteLine();// Blank line for spacing

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"Name",-15}\t||{"Serial",-10}\t||{"Price",-10}\t||{"Quantity",-5}\t||{"Category",-15}\t||{"Total Price",-15}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{strProduct1Name,-15}\t||{intProduct1SerialNumber,-10}\t||{dblProduct1Price,10:C2}\t||{intProduct1Quantity,-5}\t\t||{strProduct1Category,-15}\t||{dblProduct1TotalPrice,15:C2}");
            Console.WriteLine($"{strProduct2Name,-15}\t||{intProduct2SerialNumber,-10}\t||{dblProduct2Price,10:C2}\t||{intProduct2Quantity,-5}\t\t||{strProduct2Category,-15}\t||{dblProduct2TotalPrice,15:C2}");    
            Console.WriteLine($"{strProduct3Name,-15}\t||{intProduct3SerialNumber,-10}\t||{dblProduct3Price,10:C2}\t||{intProduct3Quantity,-5}\t\t||{strProduct3Category,-15}\t||{dblProduct3TotalPrice,15:C2}");
            Console.WriteLine($"{strProduct4Name,-15}\t||{intProduct4SerialNumber,-10}\t||{dblProduct4Price,10:C2}\t||{intProduct4Quantity,-5}\t\t||{strProduct4Category,-15}\t||{dblProduct4TotalPrice,15:C2}");




        }
    }
}
