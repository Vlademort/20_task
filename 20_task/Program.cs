using System;

namespace _20_task
{
    class Program
    {
        delegate double MyDelegate(double r);
        static double Method_L(double r)
        {           
            return 2 * Math.PI * r;
        }
        static double Method_S(double r)
        {            
            return Math.PI * r * r;
        }
        static double Method_V(double r)
        {            
            return 0.75 * Math.PI * r * r * r;
        }

        static void Result (double d,double s,double v)
        {
            Console.WriteLine($"Длина L= {d}\nПлощадь S= {s}\nОбъем V= {v}");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            MyDelegate my_delegate = Method_L;
            if (my_delegate != null)
            {
                double length = my_delegate(radius);
                Console.WriteLine("Длина окружности L= {0:f3}", length);
            }

            my_delegate = Method_S;
            if (my_delegate != null)
            {
                double square = my_delegate(radius);
                Console.WriteLine("Площадь круга S= {0:f3}", square);
            }

            my_delegate = Method_V;            
            if (my_delegate != null)
            {
                double volume = my_delegate(radius);
                Console.WriteLine("Объем шара V= {0:f3}", volume);
            }
           
            Console.ReadKey();
        }
    }
}