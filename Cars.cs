using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
    internal class Cars
    {
        private string make;
        private string model;
        private int year;
        private Engine engine;

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

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Car()
        {
            Engine = new Engine();
            Make = string.Empty;
            Model = string.Empty;
            Year = 1970;
        }

        public Car(string make, string model, int year, Engine engine)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Engine = engine;
        }

        public void Drive()
        {
            Engine.Start();
            Console.WriteLine("Driving started");
        }
        public void Stop()
        {
            Engine.Stop();
            Console.WriteLine("Driving stopped");
        }
    }
}
