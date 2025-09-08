using System.Diagnostics;

namespace Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strData = "  Norah Grace Wolff  ";
            Console.WriteLine(strData.Length); 
            Console.WriteLine($"The orriginal name is {strData}"); 
      //       remove spaces from both ends of the string
      //     strData = strData.Trim(); 
        //    Console.WriteLine(strData);
        //    Console.WriteLine(strData.Length);

           
           // removes spaces before and afte the string too 
           Console.WriteLine(strData.Trim().ToLower());
            // tunrs into upper case and lower case
            Console.WriteLine(strData.ToLower()); 
            Console.WriteLine(strData.ToUpper());

            String strProcessedName =strData.Trim();
            Console.WriteLine($"Processed name is:{strProcessedName}");
           // Console.WriteLine(strData.IndexOf("W"));
            Console.WriteLine(strProcessedName.IndexOf(" "));
            // gives subrstring from the main string. if substrign ahs one number it goes right to that loation 
            //Console.WriteLine(strProcessedName.Substring(10,3));

            //Lets find and printout the first name 
            int intFirstSpace = strProcessedName.IndexOf(" ");
            Console.WriteLine(strProcessedName.Substring(0,intFirstSpace));

            // Lets print out the middle name now 
            int intLastSpace = strProcessedName.LastIndexOf(" ");
            Console.WriteLine($"First space is at locaton {intFirstSpace} and last space is in location {intLastSpace}");
            int intMidNameLength = intLastSpace - intFirstSpace;
           // Console.WriteLine(strProcessedName.Substring(intFirstSpace+1, intMidNameLength));

            // Lets print out the last name now
           // Console.WriteLine(strProcessedName.Substring(intLastSpace+1));
            //plus one to get rid of the sapce

            // Lets try making first chararcter of middle name upper case
            string strMiddleName = strProcessedName.Substring(intFirstSpace+1, intMidNameLength);
            Console.WriteLine($"middle name is {strMiddleName}");
            Console.WriteLine(String.Concat("OP", "LO")); 
            char chrMidInitial 'O'; 
            char chrOtherCHar = 'K';
            string strCombinedChar=String.Concat(chrMidInitial, chrOtherCHar,"Howdy");
            Console.WriteLine(strCombinedChar);

            //This prints out the firstt char of the name 
            Console.WriteLine(strMiddleName.Substring(0, 1)); 

            //Print out everything after the first char 
            Console.WriteLine(strMiddleName.Substring(1));
        }
    }
}
