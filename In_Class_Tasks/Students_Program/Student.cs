using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Program
{
    public class Student
    {
        public string ID;
        public string FirstName;
        public string LastName;
        public string phone;
        private double dblGpa;


        public Student(string anID, string FName, string LName)
        {
            ID = anID;
            FirstName = FName;
            LastName= LName;
        }

        public Student(String anID)
        {
            ID = anID;
            FirstName = "";
            LastName = "";
        }
        public void SetGPA(double theGPA)
        {
            while (theGPA < 0 || theGPA > 4)
            {
                Console.WriteLine($"The {theGPA} is invalid. It has to be between 0 and 4. Insert again");
                theGPA = Double.Parse (Console.ReadLine());
            }
           dblGpa = theGPA;

        }

        public double GetGPA()
        {
            return dblGpa;
        }


        public void SetID(string theID)
        {
            ID = theID;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} with ID {ID} has GPA {dblGpa} and phone {phone}");
        }
    }
}
