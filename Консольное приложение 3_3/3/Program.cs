using System;

namespace _3
{
    class Program
    {
        static void f(double x, out double y)
        {
            if (Math.Pow(x, 2) + 2 * x + 1 < 2)
                y = Math.Pow(x, 2);
            else if (Math.Pow(x, 2) + 2 * x + 1 >= 3)
                y = 0.0;
            else
                y = (1 / (Math.Pow(x, 2) - 1));

        }

        static double f(double x)
        {
            double y = 0;
            if (Math.Pow(x, 2) + 2 * x + 1 < 2)
                y = Math.Pow(x, 2);
            else if (Math.Pow(x, 2) + 2 * x + 1 >= 3)
                y = 0.0;
            else
                y = (1 / (Math.Pow(x, 2) - 1));
            return y;
        }


        static void Main(string[] args)
        {
            double a, b, h;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Введите начало диапозона: ");
                        a = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Write("Некорректный ввод!");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введите конец диапозона: ");
                        b = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Write("Некорректный ввод!");
                    }
                }
                if (a > b)
                {
                    Console.WriteLine("Начальная точка диапазона не может быть больше конечной точки");
                    continue;
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введите шаг: ");
                        h = double.Parse(Console.ReadLine());
                        if (h == 0)
                        {
                            Console.WriteLine("Шаг не может быть равен 0");
                            continue;
                        }
                        else if (h < 0)
                        {
                            Console.WriteLine("Шаг не может быть меньше 0");
                            continue;
                        }
                        break;
                    }
                    catch
                    {
                        Console.Write("Некорректный ввод!");
                    }
                }
                break;
            }
            Console.WriteLine();
            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine("f({0:f2})={1:f2}", i, f(i));
            }
            Console.WriteLine();
            Console.WriteLine("Перегруженный метод");

            for (double i = a; i <= b; i += h)
            {
                f(i, out double y);
                Console.WriteLine("f({0:f2})={1:f2}", i, y);
            }
        }
    }
}
