using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
/// Задача 1. Разработать класс, описывающий точку. В классе должны быть определены 1.закрытые поля для координат точки;
/// 2.свойства для доступа к полям;3.конструктор без параметров и конструктор с параметрами, принимающий координаты точки;
/// 4.метод для вывода координат точки. Создать массив из точек и заполнить его различными способами (через инициализацию, через 
/// заполнение с клавиатуры, через создание динамического массива и заполнение его с клавиатуры). Каждый способ заполнения массива просмотреть.
/// </summary>
    class Calc
    {        
            private double x;
            private double y;
            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }
            public Calc()
            {
                x = 0;
                y = 0;
            }
            public Calc(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public void PrintCoordinates()
            {
                Console.WriteLine($"Точка: ({x}, {y})");
            }
    }
}
