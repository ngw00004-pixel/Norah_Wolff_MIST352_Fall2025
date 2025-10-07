namespace In_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strMagicWord;
            Console.WriteLine("What is 5 * 5");
            strMagicWord = Console.ReadLine();
            while (strMagicWord != "cats")
            {
                Console.WriteLine("Wrong Magic Word. Try Again");
                strMagicWord = Console.ReadLine();
            }
        }
    }
}
