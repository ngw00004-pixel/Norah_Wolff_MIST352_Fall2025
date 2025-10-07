namespace array_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // basic array
            int[] nums = new int[3]; // 3 boxes 
            // length
            Console.WriteLine(nums.Length);
            // ranges and slices
            string[] langs = {"C#", "Java", "Python", "JavaScript" };
            Console.WriteLine (string.Join(", ", langs[1..3]));
            // multidimensional array
            int[,] grid = new int[2, 3]; // 2 rows, 3 colums 
            int[][] jagged =new int[2][]; // 2 rows
            jagged[0] = new int[3]; 
            jagged[1] = new int[1]; 
                                   

        }
    }
}
