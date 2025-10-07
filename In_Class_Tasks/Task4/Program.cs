namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // defined six integers
            int[] intArray = {1,2,3,4,5,6};

            // call a method to print array elements 
            PrintArray(intArray);

            // call method to calc and show average 
            double dblAverage = FindAverage(intArray);
            Console.WriteLine($"The average is: {dblAverage}");

            // ask user to enter a number 
            Console.Write("Enter a number to search for: ");
            int intTarget = Convert.ToInt32(Console.ReadLine());

            // call method to search for the number 
            SearchNumber(intArray, intTarget);

        }
        /// <summary>
        /// Prints the elements of an integer
        /// <summary>
        /// <param name="intArray">The array of integers to print.</param>"
        /// 
        static void PrintArray(int[] intArray)
        {
            Console.Write("The array elements are: ");
            foreach (int intValue in intArray)
            {
                Console.Write($"{intValue}");
            }
            Console.WriteLine(); // adds a line break 
        }
        /// <summary>
        /// Calcualtes and returns the average of the array elements 
        /// </summary>
        /// <param name="intArray">Array of integers</param>
        /// <returns>Average as a double</returns>
        static double FindAverage(int[] intArray)
        {
            int intSum = 0;
            foreach (int intValue in intArray)
            {
                intSum += intValue;
            }
            return (double) intSum/ intArray.Length;
        }
        /// <summary>
        /// Searches for a target number in the array and prints the result
        /// <!--/summary>-->
        /// <param name="intArray">Array of integers</param>
        /// <param name="intTarget">Target number to search for</param>
        static void SearchNumber(int[] intArray, int intTarget)
        {
            bool blnFound = false;
            foreach (int intValue in intArray)
            {
                if (intValue == intTarget)
                {
                    blnFound = true;
                    break;
                }
            }
            if (blnFound)
            {
                Console.WriteLine($"The number {intTarget} was found in the array.");
            }
            else
            {
                Console.WriteLine($"The number {intTarget} was not found in the array.");
            }
        }
    }
}



