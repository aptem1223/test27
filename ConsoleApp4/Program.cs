using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car1[] cars1 = new Car1[3];
            cars1[0] = new Car1("Toyota", "Corolla", 2010);
            cars1[1] = new Car1("Ford", "Focus", 2015);
            cars1[2] = new Car1("Honda", "Civic", 2020);

            Console.WriteLine("Автомобили, инициализированные через массив:");
            foreach (var car in cars1)
            {
                car.PrintCarInfo();
            }

            Car1[] cars2 = new Car1[2];
            for (int i = 0; i < cars2.Length; i++)
            {
                Console.WriteLine($"Введите информацию для автомобиля {i + 1}:");
                Console.Write("Введите марку: ");
                string make = Console.ReadLine();
                Console.Write("Введите модель: ");
                string model = Console.ReadLine();
                Console.Write("Введите год выпуска: ");
                int year = Convert.ToInt32(Console.ReadLine());

                cars2[i] = new Car1(make, model, year);
            }

            Console.WriteLine("\nАвтомобили, введенные с клавиатуры:");
            foreach (var car in cars2)
            {
                car.PrintCarInfo();
            }

            Console.WriteLine("\nСоздание динамического массива автомобилей:");
            Console.Write("Введите количество автомобилей: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Car1[] cars3 = new Car1[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите информацию для автомобиля {i + 1}:");
                Console.Write("Введите марку: ");
                string make = Console.ReadLine();
                Console.Write("Введите модель: ");
                string model = Console.ReadLine();
                Console.Write("Введите год выпуска: ");
                int year = Convert.ToInt32(Console.ReadLine());

                cars3[i] = new Car1(make, model, year);
            }

            Console.WriteLine("\nАвтомобили, созданные динамически:");
            foreach (var car in cars3)
            {
                car.PrintCarInfo();
            }
        }
    }
}
