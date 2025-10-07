namespace In_class_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this program will demonstrate basic arithmetic operations in C#
            int intVal1 = 90, intVal2 = 10;
            GreetUser(); // method call
            Console.WriteLine(SumTwoNumbers(intVal1, intVal2)); // method call with parameters
            Console.WriteLine(MultiplyTwoNumbers(intVal1, intVal2)); // method call with parameters too
            AskUserNameAndGreet(); // method call
            Console.WriteLine($"The lettergrade of {intVal1} is {ObtainLetterGrade(intVal1)}"); 

        }

        static char ObtainLetterGrade(double dblGPA) // this is method signature // takes past varibales and returns a variable
        {
            char chrGrade;
            if (dblGPA >= 3.5)
            {
                chrGrade = 'A';
            }
            else if (dblGPA >= 2.5)
            {
                chrGrade = 'B';
            }
            else if (dblGPA >= 1.5)
            {
                chrGrade = 'C';
            }
            else if (dblGPA >= 0.5)
            {
                chrGrade = 'D';
            }
            else
            {
                chrGrade = 'F';
            }
            return chrGrade;
        }


        static int SumTwoNumbers(int intFirstVal, int intSecondVal) // this is method signature // takes past varibales and returns a variable
        {
            int intSum = intFirstVal + intSecondVal;
            return intSum;
        }
        /// <summary>
        /// THis greets user by printing out a message
        /// </summary>
        static void GreetUser() // this is method signature // takes no variables and returns nothing
        {
            Console.WriteLine("Hello User, Welcome to C# Programming");
        }


        // create a methoid that accpets two values and multiples them and returns that 
        static int MultiplyTwoNumbers(int intX, int intV) // this is method signature // takes past varibales and returns a variable
        {
            int intZ = intX * intV;
            return intZ;
        }

        static void AskUserNameAndGreet() // this is method signature // takes no variables and returns nothing
        {
            Console.WriteLine("Please enter your name: ");
            string strUserName = Console.ReadLine();
            Console.WriteLine($"Its good to see you {strUserName}");
        }
    }
}
