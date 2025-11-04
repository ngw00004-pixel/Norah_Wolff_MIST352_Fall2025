using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FancyStudent
{
    private string _name;
    private int _age;
    private double _gpa;
    public string Name { get; set; }

    public string Name
    {
        
    }
    // Constructor with 3 arguments
    public FancyStudent(string name, int age, double gpa)
    {
        _name = name;
        _age = age;
        _gpa = gpa;
        Name = name;
    }

    // Constructor with 1 argument (age)
    public FancyStudent(int age)
    {
        _age = age;
    }

    // Parameterless constructor
    public FancyStudent()
    {
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}, Age: {_age}, GPA: {_gpa}");
    }

    public bool IsHonorStudent()
    {
        return _gpa >= 3.5;
    }

    // Expose age for demonstration (since Program.cs uses Student1.age)
    public int age => _age;
}
internal class Program
{
    static void Main(string[] args)
    {
        var Student1 = new FancyStudent("Sarah Ahmad", 22, 3.5);
        var Student2 = new FancyStudent("John Doe", 20, 3.8);
        var Student3 = new FancyStudent(22);
        var St1 = new FancyStudent();

        Student1.DisplayInfo();
        Student2.DisplayInfo();
        Student3.DisplayInfo();

        Console.WriteLine(Student1.age);

        /* ... */
    }
}
