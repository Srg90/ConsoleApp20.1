using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20._1
{
    internal class Program
    {
        delegate double Task20(double r);

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Задайте значение радиуса: ");
                double r = double.Parse(Console.ReadLine());

                Task20 task1 = Circumference;
                Task20 task2 = Area;
                Task20 task3 = SphereVolume;

                if (task1 != null & task2 != null & task3 != null)
                {
                    double result1 = task1(r);
                    Console.WriteLine(Math.Round(result1, 2));
                    double result2 = task2(r);
                    Console.WriteLine(Math.Round(result2, 2));
                    double result3 = task3(r);
                    Console.WriteLine(Math.Round(result3, 2));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                                    
            Console.ReadKey();
        }

        public static double Circumference(double r)
        {
            double p = 2 * Math.PI * r;
            Console.WriteLine();
            Console.Write("Длина окружности = ");
            return p;
        }

        public static double Area(double r)
        {
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine();
            Console.Write("Площадь круга = ");
            return s;
        }

        public static double SphereVolume(double r)
        {
            double v = (4 * Math.PI * Math.Pow(r, 3)) / 3;
            Console.WriteLine();
            Console.Write("Объем шара = ");
            return v;
        }

    }
}
