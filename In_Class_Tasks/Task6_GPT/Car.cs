using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_GPT
{
    public class Car
    {
        // Private fields
        private string make;
        private string model;
        private int year;

        // Default constructor
        public Car()
        {
            this.make = "Generic";
            this.model = "Car";
            this.year = 2024;
        }

        // Constructor with make and model (uses current year)
        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
            this.year = DateTime.Now.Year;
        }

        // Constructor with make, model, and year
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        // Getters and setters
        public string getMake() { return make; }
        public void setMake(string make) { this.make = make; }

        public string getModel() { return model; }
        public void setModel(string model) { this.model = model; }

        public int getYear() { return year; }
        public void setYear(int year) { this.year = year; }

        // Display method
        public void DisplayInfo()
        {
            Console.WriteLine("Car Info:");
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year: " + year);
            Console.WriteLine();
        }
    }

}
