/* Ask user for multiple grades, then evaluate and summarize
 * Also done on thrusday the 16th 
 */
namespace IF_Multiple_Grades_Evaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many grades would you like to evaluate and summarize?");
            // Accept number of grades
            int intNumberGrades = Convert.ToInt32(Console.ReadLine());
            int intAs=0, intBs=0, intCs=0, intDs=0, intFs=0, IntPass=0, IntFail=0;

            // Create and array to hold grades.
            double[] dblGrades = new double[intNumberGrades];
            char[] chrLetterGrades = new char[intNumberGrades];

            // A for loop to interact with the array. Fill it up with grades from the user 
            for(int intIndex = 0; intIndex < dblGrades.Length; intIndex++)
            {
                // Accept one grade nd add it to the current element in the array 
                Console.WriteLine($"Give me a grade {intIndex + 1}:");
                dblGrades[intIndex] = Convert.ToDouble(Console.ReadLine());
            }
            // Another for loop to evaluate each and store in an other array 
            // Increment the variable that track the number of each letter grade by one when seen 
            for (int intIndex = 0; intIndex < dblGrades.Length; intIndex++)
            {
                if (dblGrades[intIndex] >= 90)
                {
                    chrLetterGrades[intIndex] = 'A';
                    intAs++;

                }

                else if (dblGrades[intIndex] >= 80)
                {
                    chrLetterGrades[intIndex] = 'B';
                    intBs++;
                }
                else if (dblGrades[intIndex] >= 70)
                {
                    chrLetterGrades[intIndex] = 'C';
                    intCs++;
                }
                else if (dblGrades[intIndex] >= 60)
                {
                    chrLetterGrades[intIndex] = 'D';
                    intDs++;
                }
                else
                {
                    chrLetterGrades[intIndex] = 'F';
                    intFs++;
                }
                Console.WriteLine($"Number of A\t\t {intAs}\nNumber of B\t\t {intBs}\nNumber of C\t\t {intCs}\nNumber of D\t\t {intDs}\nNumber of F\t\t {intFs}+" +
                    $"Number of Passes\t\t\{intAs+intBs+intCs+intDs}\n Number of fails \t\t {intFs}");

                

            }
        }
    }
}
