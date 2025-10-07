using System.Text;

namespace CH2_Practice
{
    internal class Program
    {
        static void Main(string[] args)
           /* ---Type Names ---
             *  Full name: System.String
             * Short name: string
             * Ketword: string
             *  
             *  
             */
        {
            string name1 = "Norah"; // keyword
            string name2 = "Norah"; // short name
            System.String name3 = "Norah Grace Wolff"; // full name
            Console.WriteLine($"{name1}, {name2}, {name3}");

            // Integer Types 
            int a = 42; // normal integer
            long b = 12345678901234; // large integer
            byte c = 255; // small unsigned integer
            Console.WriteLine($"int: {a}, long: {b}, byte: {c}");

            // floating-point types
            float piFloat = 3.14159f; // 7 digit precision
            double piDouble = 3.141592653589793; // 15-16 digit precision
            decimal money = 19.99m; // exact for $$$
            Console.WriteLine($"float:{piFloat}");
            Console.WriteLine($"double:{piDouble}");
            Console.WriteLine($"decimal:{money}");

            //Literals 

            Console.WriteLine(42); // int 
            Console.WriteLine(42L); // long 
            Console.WriteLine(42U); // unsigned int
            Console.WriteLine(1.6180339887); // double default for decimals
            Console.WriteLine(1.6180339887M); // decimal

            // digit separatiors 
            Console.WriteLine(9_814_072_356); // underscore for readability

            // exponential notation
            Console.WriteLine(6.023E23F); // avogadro's number as a float

            // hexadecimal and binary literals
            Console.WriteLine(0x2A); // 42 in hex
            Console.WriteLine(0b0010_1010); // 42 in binary

            // formatting 
            int hexNumber = 255;
            Console.WriteLine($"0x{hexNumber:X}"); // shows number in hex: 0x2A

            // bool 
            bool passedExam = true;
            Console.WriteLine($"Did I pass the exam? {passedExam}");

            // char 
            char grade ='A';
            char smiley = '\u263A'; // Unicode smiley face
            Console.WriteLine($"Grade: {grade}, Smiley: {smiley}");

            // strings 
            string name = "Norah";
            string food = "sushi";
            Console.WriteLine($"Hello, {name}. Let's eat some {food}.");

            // Verbatim string literal
            string filePath = @"C:\Users\Norah\Documents\file.txt";
            Console.WriteLine($"File path: {filePath}");

            // raw string literal (multi-line) 
            string poem = """
                Roses are red,
                Violets are blue,
                C# is hard,
                But I will get through.
                """;
            Console.WriteLine(poem);

            // StringBuilder
            StringBuilder sb = new StringBuilder("I like");
            sb.Append(" Coding");
            sb.Replace("like", "love");
            Console.WriteLine(sb.ToString());

            // null example 
            string? nickname = null;
            Console.WriteLine($"Nickname is: {(nickname == null ? "not set" : nickname)}");

            // void example ( calls method below) 
            // PrintDivider(); 
            // method with void return type 
            // static void PrintDivider()

            // explict cast 
            long pizzaSlices = 999999999; // way too many slices 
            int smallPlate = (int)pizzaSlices; // explicit cast, might lose data
            Console.WriteLine($"Tried to fit {pizzaSlices} slices on a small plate --> {smallPlate}");

            // checled (catiching overflow)
            try
            {
                int maxInt = int.MaxValue;
                maxInt= maxInt + 1; // this will overflow
                Console.WriteLine($"Checked result: {maxInt}");

            }
            catch (OverflowException)
            { Console.WriteLine("Party bouncer: Too many slices! You're out");
            }

            //impict conversation (safe)
            int cups = 5;
            long biggerCups = cups; // fits line 
            Console.WriteLine($"Cups upgraded safely --> {biggerCups}");

            // parse vs TryParse
            string input = " forty-two";
            try
            {
                int number =int.Parse(input); // throws exception
                Console.WriteLine($"Parse suceed: {number}");

            }
            catch (FormatException)
            {
                Console.WriteLine($"Parse crashed: can't turn words into numbers!");

            }
            if(int.TryParse(input, out int saferNumber))
            {
                Console.WriteLine($"TryParse worked: {saferNumber}");
            }
            else
            {
                Console.WriteLine($"TryParse says no, but at least no crash!");
            }

            //Tostring 
            bool isHungry = true;
            Console.WriteLine($"Boolean as string: {isHungry.ToString()}");


            Console.WriteLine("----- End of Notes Practice -----");







        }
    }
}
