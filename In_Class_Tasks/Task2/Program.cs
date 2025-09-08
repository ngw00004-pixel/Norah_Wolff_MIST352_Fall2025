/*Norah Wolff
 * Task2
 *
 */
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the name of your hero?");

        string name = Console.ReadLine();
            Console.Write("What is your favorite place?");
            string place = Console.ReadLine();
            Console.Write($"What is your lucky number?");
            string luckyNumberText = Console.ReadLine();

            // after all questions are answered 
            string heroName = name; 
            string favoritePlace = place;
            //string luckyNumberText=Console.ReadLine();

            //Clean heroName and favoritePlace by Trim 
            heroName =heroName.Trim();
            favoritePlace=favoritePlace.Trim();

            //Try PARSE luckyNumberText to int
            bool parseOkay=int.TryParse(luckyNumberText, out int luckyNumber);

            // build line1 ="meeet" +Upper and hero name 
            string line1 = "Meet " + heroName.ToUpper() + "!";
            // new line todays quest starts and fav place 
            string line2 = "Today your quest starts in " + favoritePlace + ".";
            //Build line 3 = "Lucky Number" + luckyNumber 
            string line3 = "Lucky Number: " + luckyNumber;
            //build code = "#" + nick +"-" + luckyNumber and build nick 
            string nick = heroName.Length>=3 ? heroName.Substring(0, 3).ToUpper() : heroName.ToUpper();
            string code = "#" +nick+"-" + luckyNumber;
            // BUILD report =line1 +NEWLINE +line2 + NEWLINE + line3 + "QuestCode:" + code
            string report= line1 + Environment.NewLine + line2 + Environment.NewLine + line3 + Environment.NewLine + "Quest Code: " + code;
            //PRINT report
            Console.WriteLine(report);
            // print "parse sucess:" + parseOkay
            Console.WriteLine("Parse sucess:" + parseOkay);
            // Print "Hero length:" + LENGTH(heroName)
            Console.WriteLine("Hero length:" + heroName.Length);
            //Print "Place containts a space: "+(INDEX_OF(favoritePlace, " ")>=0)
            Console.WriteLine("Place contains a space: " + (favoritePlace.IndexOf(" ") >= 0));

        }
    }
}
