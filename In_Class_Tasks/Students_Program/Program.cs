namespace Students_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FancyStudent Student1 = new FancyStudent("Sarah Ahmad", 22, 3.5);
            FancyStudent Student2 = new FancyStudent("John Doe", 20, 3.8);
            FancyStudent Student3 = new FancyStudent(22);
            FancyStudent St1 = new FancyStudent();

            Student1.DisplayInfo();
            Student2.DisplayInfo();
            Student3.DisplayInfo();

            Console.WriteLine(Student1.Name);

            /*Student mj = new Student("800-0000", "MJ", "Ahmad");
            mj.SetID("8000-1111");
            mj.FirstName = "MJ";
            mj.LastName = "Ahmad";
            mj.SetGPA(3.1);
            mj.phone = "610- 555-1234";
            mj.PrintInfo();

            Student Ashley = new Student("850-0000", "Ashley", "Smith");

            Student norah = new Student("900-0000", "Norah", "Wolff");
            norah.SetID("900-0000");
            norah.FirstName = "Norah";
            norah.LastName = "Wolff";
            norah.SetGPA(3.8);
            norah.phone = "610-500-5128";
            norah.PrintInfo();

            if (mj.GetGPA() < norah.GetGPA())
            {
                Console.WriteLine($"{norah.FirstName} is smarter than {mj.FirstName}");

            }
            else
            {
                Console.WriteLine($"{mj.FirstName} is smarter than {norah.FirstName}");
            }*/

        }
    }
}
