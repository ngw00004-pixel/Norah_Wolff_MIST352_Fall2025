/*  Norah Wolff
 * This is study for quiz 1 with notes and basic codes to underwstand concepts
 * 
 */
namespace StudyPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // A variable is a name for storing a value that can change
            // a local variable is delcared inside a method like (Main())
            // Below is an example of a local variable
            string max;// make an empty box called max
            max = "Hi have fun doing your homework!";// put a value in the box
            Console.WriteLine(max);// get the value from the box and print it to the screen

            /* To declare a varibale you need two things the type which is what goes in the box 
            // and the name of the box
            string max; // box for text 
            */
            // int age; // box for whole numbers
            // char letter; // box for a single character

            // to assign a varibale ( put stuff in box) use the = sign
            // string greeting = "Hello!"; // box for text with stuff in it
           //  greeting = "Bye!"; // change the stuff in the box

            //Rules for naming boxes (variables)
            // start with a letter or underscore, can use letters, numbers
            // use camelcase eg. miracleMax or norah 

            // using variables (opening the box) just call the box by its name 
            Console.WriteLine("greeting");// this prints whats inside greeting 

            // strings are special boxes 
            // string is texbox (words/sentences)
            // strings are frozen and you cant change the letters inside
            // if you want to change the letters you have to make a new string
            string song = "Hello darkness my old friend";
            song = "I've come to talk with you again"; // new text, old one gone 

            // if u use console writeling it writes text and goes to new line 
            // console write just writes text and stays on the same line
            Console.Write("Hello ");// stays on same line
           Console.WriteLine("Goodbye"); // goes down a line 

            // Input is listening to user
            Console.ReadLine(); // waits for user to type something and hit enter
            // whatever the user types is returned as a string
            string firstName; // make a box for first name
            Console.WriteLine("Enter your first name: ");// ask user for first name
            firstName = Console.ReadLine(); // put what user types in the box

            string lastName; // make a box for last name
            Console.WriteLine("Enter your last name: ");// ask user for last name
            lastName = Console.ReadLine(); // put what user types in the box


            // advanced inputs 
            // console. read () reads 1 character but gived it back as a number 
            int readvalue = Console.Read(); // read 1 character from user   
            char letter = (char)readvalue; // convert number to character
            Console.Write (letter);// print the character

            //string interpolation easy way to combine text and variables
            // instead of writing losts of writeline peices use $
            // inside curly braces put the variable name

            Console.WriteLine($"your full name is {firstName} {lastName}.");

            // composite formatting the old way pre- c# 6
            // use {} as placeholders for variables
            Console. WriteLine("your full name is {0} {1}.", firstName, lastName);
            // {0} first varibale after string {1} second variable after string and so on 
            // you can reorder 
            Console.WriteLine("your full name is {1}, {0}.", firstName, lastName);

            // obviously dont comment obvious code when coding this is notes but write clean code

            // xml= text format that stores data and descriptions of data look like html but for data 

 








        }
    }
}
