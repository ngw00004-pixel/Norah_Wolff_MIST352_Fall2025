/* 
 * Tuesday 9/16/25 
 * Simple program to evaluate and print out a given grade 
 * 
 */
namespace IF_Simple_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a grade");
            double dblGrade = Double.Parse(Console.ReadLine());

            if(dblGrade is >100  || dblGrade < 0 )
            {
                Console.WriteLine("Invalid Input. Should be between 0 and 100. Rerun again"); 
                return; // breaks the program, makes it stop for now 
            }

            if (dblGrade >= 90) // no semicolon
            {
                Console.WriteLine("A");
            }
            else if (dblGrade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (dblGrade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (dblGrade >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
