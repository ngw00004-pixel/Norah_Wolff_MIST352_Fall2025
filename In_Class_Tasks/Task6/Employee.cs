using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Employee
    {
        private string name;
        private double hourlyRate;
        private int hoursPerWeek;

        // Default constructor
        public Employee()
        {
            this.name = "New Hire";
            this.hourlyRate = 15.0;
            this.hoursPerWeek = 40;
        }

        // Constructor with name only
        public Employee(string name)
        {
            this.name = name;
            this.hourlyRate = 15.0;
            this.hoursPerWeek = 40;
        }

        // Constructor with all parameters
        public Employee(string name, double rate, int hours)
        {
            this.name = name;
            this.hourlyRate = rate;
            this.hoursPerWeek = hours;
        }

        // Getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public int HoursPerWeek
        {
            get { return hoursPerWeek; }
            set { hoursPerWeek = value; }
        }

        // Calculate annual salary
        public double AnnualSalary
        {
            get { return hourlyRate * hoursPerWeek * 52; }
        }

        // Display summary
        public void DisplaySummary()
        {
            Console.WriteLine($"Employee: {name}");
            Console.WriteLine($"Annual Salary: ${AnnualSalary:F2}");
        }
    }
}
