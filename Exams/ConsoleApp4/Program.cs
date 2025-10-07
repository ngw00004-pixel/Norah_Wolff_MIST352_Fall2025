namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ### 15) i++ vs ++i – Order of Operations
            // WHAT: Post-increment returns old value; pre-increment increments first.
            {
                Console.WriteLine("### 15) i++ vs ++i – Predict and Check");

                int intI = 3;
                Console.WriteLine(intI++); // prints 3, then intI becomes 4
                Console.WriteLine(++intI); // intI becomes 5, then prints 5
                Console.WriteLine(intI);   // prints 5
            }

        }
    }
}
