using System;

namespace _1
{
    class Program
    {
        static int f(int x)
        {
            return (x / 10) % 10;
        }
        static void Main(string[] args)
        {
            int a,b,c;
            while (true)
            {
                try
                {
                    Console.Write("Введите a: ");
                    a = int.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("0 - не натуральное чило");
                        continue;
                    }
                    else if ((a< 10) || (a < 0))
                    {
                        Console.WriteLine("Минимальное число 10");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Введите b: ");
                    b = int.Parse(Console.ReadLine());
                    if (b == 0)
                    {
                        Console.WriteLine("0 - не натуральное чило");
                        continue;
                    }
                    else if ((b < 10) || (b < 0))
                    {
                        Console.WriteLine("Минимальное число 10");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Введите c: ");
                    c= int.Parse(Console.ReadLine());
                    if (c == 0)
                    {
                        Console.WriteLine("0 - не натуральное чило");
                        continue;
                    }
                    else if ((c < 10)||(c<0))
                    {
                        Console.WriteLine("Минимальное число 10");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            int res = f(a) + f(b) - f(c);
            Console.WriteLine("Результат вычисления = " + res);

        }

    }
}
