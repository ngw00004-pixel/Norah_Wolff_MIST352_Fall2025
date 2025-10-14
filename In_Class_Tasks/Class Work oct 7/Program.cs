namespace Class_Work_oct_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* int[] intValues = { 11, 21, 13 };
             Console.WriteLine($"Before {intValues[0]}");

             PrintArray(intValues);
             Console.WriteLine($"After {intValues[0]}");*//*

            int intFirstVal = 1, intSecondVal = 2, intThirdVal;
            Console.WriteLine($"Before Method: {intFirstVal}, {intSecondVal}");
            //Multiply( ref intFirstVal, intSecondVal);
            Console.WriteLine(Multiply_Return(ref intFirstVal, intSecondVal));
            Console.WriteLine($"After Method: {intFirstVal}, {intSecondVal}");*/

            string strEmail;
            AcceptVerifyEmail(out strEmail);
            Console.WriteLine(strEmail);
        }

        static void AcceptVerifyEmail(out string strEmailToVerify)
        {
           strEmailToVerify = Console.ReadLine();
              if (strEmailToVerify.Contains("@") && strEmailToVerify.Contains("."))
              {
                Console.WriteLine("Valid Email");
              }
              else
              {
                Console.WriteLine("Invalid Email, Email is N/A");
                strEmailToVerify = "N/A";
            }
        }

        static void Sum(int x, int y, out int z)
        {
            x = z = 10;
            Console.WriteLine(x + y + z);
        }
        static void PrintArray(int[] intData)
        {
            intData[0] = 1000; // Modifying the first element of the array
            for (int intIndex = 0; intIndex < intData.Length; intIndex++)
            {
                Console.WriteLine(intData[intIndex]);
            }
        }

        static void Multiply (ref int intVal1, int intVal2) // pass by reference allows modification of the original variable
        {
            intVal1 = 100;
            intVal2 = 0; // this change won't affect the original variable
            Console.WriteLine(intVal1 * intVal2);
        }

        static int Multiply_Return(ref int Val1, int Val2)
        {
            Val1 = 200;
            Val2 = 1;
            return Val1 * Val2;
        }

    } 


}
