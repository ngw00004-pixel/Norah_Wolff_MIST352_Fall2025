namespace Chapter_3_arrays_and_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // degine an array of grades and assesements 
            string[] strAssesments = { "Task1", "HW1", "Task2", "Quiz1", "Exam1", "HW2", "task3", "hw3"};
            float[] floatGrades = { 90, 88, 70, 95, 60, 50, 90, 55 };

            // for loop to access/ read/ manipulate contnets of the array 
             for  (int intIndex = 0; intIndex < strAssesments.Length; intIndex++)
            {
                Console.WriteLine($" Assesment {strAssesments[intIndex]}\t\t grade {floatGrades[intIndex]}");
            }

            for (int intIndex = 0; intIndex < strAssesments.Length; intIndex++)
            {
                if (strAssesments[intIndex].ToLower() .Contains("HW".ToLower())) strAssesments[intIndex].Contains("Task1".ToLower());
                {
                    Console.WriteLine($" Assesment {strAssesments[intIndex]}\t\t grade {floatGrades[intIndex]}");
                }
            }




        }
    }
}
