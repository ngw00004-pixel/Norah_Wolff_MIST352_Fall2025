using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_GPT
{
    internal class Employee
    {
        // Private fields
        private String name;
        private double hourlyRate;
        private int hoursPerWeek;

        // Default constructor
        public Employee()
        {
            this.name = "New Hire";
            this.hourlyRate = 15.00;
            this.hoursPerWeek = 40;
        }

        // Constructor with name only
        public Employee(String name)
        {
            this.name = name;
            this.hourlyRate = 15.00;
            this.hoursPerWeek = 40;
        }

        // Constructor with name, rate, and hours
        public Employee(String name, double hourlyRate, int hoursPerWeek)
        {
            this.name = name;
            this.hourlyRate = hourlyRate;
            this.hoursPerWeek = hoursPerWeek;
        }

        // Getters and setters
        public String getName() { return name; }
        public void setName(String name) { this.name = name; }

        public double getHourlyRate() { return hourlyRate; }
        public void setHourlyRate(double hourlyRate) { this.hourlyRate = hourlyRate; }

        public int getHoursPerWeek() { return hoursPerWeek; }
        public void setHoursPerWeek(int hoursPerWeek) { this.hoursPerWeek = hoursPerWeek; }

        // Display method
        public void DisplaySummary()
        {
            double annualSalary = hourlyRate * hoursPerWeek * 52;
            Console.WriteLine("Employee Summary:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Annual Salary: $" + annualSalary.ToString("F2"));
            Console.WriteLine();
        }
    }
}
