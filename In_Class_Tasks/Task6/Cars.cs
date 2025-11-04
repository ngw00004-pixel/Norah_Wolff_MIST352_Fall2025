using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Car
    {
        private string make;
        private string model;
        private int year;

        // Default constructor
        public Car()
        {
            this.make = "Unknown";
            this.model = "Unknown";
            this.year = DateTime.Now.Year;
        }

        // Constructor with make and model (uses current year)
        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
            this.year = DateTime.Now.Year;
        }

        // Constructor with all parameters
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        // Getters and setters
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        // Display method
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {year} {make} {model}");
        }
    }
}
