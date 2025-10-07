namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ### 4) Strings – Clean and Format Full Name (inline only, no methods)
            // WHAT: Trim, capitalize first letter, lowercase rest.
            {
                Console.WriteLine("### 4) Strings – Clean and Format Name");

                // FIRST NAME
                Console.Write("First name: ");
                string? strFirst = Console.ReadLine();
                if (strFirst == null) strFirst = "";
                strFirst = strFirst.Trim();
                if (strFirst.Length > 0)
                {
                    string strFirstRest = (strFirst.Length > 1) ? strFirst.Substring(1).ToLower() : "";
                    strFirst = char.ToUpper(strFirst[0]) + strFirstRest;
                }

                // LAST NAME
                Console.Write("Last name: ");
                string? strLast = Console.ReadLine();
                if (strLast == null) strLast = "";
                strLast = strLast.Trim();
                if (strLast.Length > 0)
                {
                    string strLastRest = (strLast.Length > 1) ? strLast.Substring(1).ToLower() : "";
                    strLast = char.ToUpper(strLast[0]) + strLastRest;
                }

                Console.WriteLine($"Hello, {strFirst} {strLast}!");
            }

        }
    }
}
