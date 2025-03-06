using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car1
    {
        private string make;
        private string model;
        private int year;

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

        public Car1()
        {
            make = "Неизвестная марка";
            model = "Неизвестная модель";
            year = 2000;
        }

        public Car1(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Марка: {make}, Модель: {model}, Год выпуска: {year}");
        }
    }
}
