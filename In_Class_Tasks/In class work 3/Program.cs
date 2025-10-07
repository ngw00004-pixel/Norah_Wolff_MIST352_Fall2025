/*Norah wolff 
 * Calculates the average of 5 grades and displays it with the name. learning to use array and how it makes code less redundant.
 * Sept 9 in class code 
 */
namespace In_class_work_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String strName = "Norah Wolff";
            // If you want to make a less redundant code you can use an array, they allow you to store multiple values in a single variable.  
            // 5 variables in one variable instead of 5 different variables.
            double dblGrade1 =50, dblGrade2=90, dblGrade3=63, dblGrade4=80, dblGrade5 = 70, dblAverage=0, dblSum=0;
           // dblAverage = (dblGrade1 + dblGrade2 + dblGrade3 + dblGrade4 + dblGrade5) / 5;
            //Console.WriteLine($"Hello {strName}, The average is {dblAverage}");

            // Define an array of double to store the grades 
            // Array can only store one type of data, here it is storing double values. Can hold up to 5 values.
            // ONLY DEFINING ONE VARIABLE. This is one way to do it 

            // double[] dblGrades = new double[5] ;
           // dblGrades[0] = 50;
            //dblGrades[1] = 90;
            //dblGrades[2] = 63;
            //dblGrades[3] = 80;
            //dblGrades[4] = 70;

            // this is even more simple way to define an array and assign values to it.
            double[] dblGradesFancy= { 50, 90, 63, 80, 70, 90, 99};
            string[] strAssesments = { "TasK1", "HW1", "Task2", "Quiz1", "Exam1" , "Exam1", "HW2", "Exam2" };
            // something wrong with this line below, it is not working look back to fix. 
            //Console.WriteLine($"{dblGradesFancy[0]} - {dblGradesFancy [1]} - {dblGradesFancy [2]} - {dblGradesFancy [3]} - {dblGradesFancy [4]}");
            // calculate average manually
            //dblAverage = (dblGradesFancy[0] + dblGradesFancy[1] + dblGradesFancy[2] + dblGradesFancy[3] + dblGradesFancy[4]) / 5;
            //Console.WriteLine($"Hello {strName}, The average is {dblAverage}");

            // for loop to interact with the array
            //first time using semicolon inside of the parenthesis
            //first portion of for loop is the initialization, second portion is the condition, third portion is the increment.
            //for loop is saying start at 0, go until you reach 5, and increase by 1 each time. plys plus is the same as intIndex = intIndex + 1
            // how to tell for loop to keep interacting with values in the array 
            // length is a property of the array, it tells you how many values are in the array.

            for (int intIndex = 0; intIndex < dblGradesFancy.Length; intIndex++ )
            {
            
               // Console.WriteLine($"{strAssesments[intIndex]}={dblGradesFancy[intIndex]}");
               dblSum = dblSum + dblGradesFancy[intIndex];
                dblSum += dblGradesFancy[intIndex]; // this is the same as the line above, just a shortcut way to write it.

            }

            Console.WriteLine($"The average is {dblSum / 7}"); // this is hard coded, not the best way to do it.

            // practice using foreach loop now going to make for loop for eagles football game averages in another project. 
            


        }
    }
}
