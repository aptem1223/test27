using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc[] calc1 = new Calc[3];
            calc1[0] = new Calc(1.5, 2.5);
            calc1[1] = new Calc(3.5, 4.5);
            calc1[2] = new Calc(5.5, 6.5);

            Console.WriteLine("Точки, инициализированные через массив:");
            foreach (var calc in calc1)
            {
                calc.PrintCoordinates();
            }

            Calc[] calc2 = new Calc[2];
            for (int i = 0; i < calc2.Length; i++)
            {
                Console.WriteLine($"Введите координаты для точки {i + 1}:");
                Console.Write("Введите X: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                calc2[i] = new Calc(x, y);
            }

            Console.WriteLine("\nТочки, введенные с клавиатуры:");
            foreach (var calc in calc2)
            {
                calc.PrintCoordinates();
            }
            Console.WriteLine("\nСоздание динамического массива точек:");
            Console.Write("Введите количество точек: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Calc[] calc3 = new Calc[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите координаты для точки {i + 1}:");
                Console.Write("Введите X: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                calc3[i] = new Calc(x, y);
            }

            Console.WriteLine("\nТочки, созданные динамически:");
            foreach (var calc in calc3)
            {
                calc.PrintCoordinates();
            }
        }
    }
}
