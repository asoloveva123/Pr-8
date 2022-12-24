using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: "); //Ввод любого трехзначного числа и вывод на экран
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int c = n % 10;
            int b = n % 100 / 10;
            if (a == b && b == c)
            {
                Console.WriteLine("Цифры трехзначного числа одинаковые"); //Если цифрыы трехзнаного ччисла одинаковые
            }
            else
            {
                Console.WriteLine("Цифры трехзначного числа не одинаковые"); //Если цифры трехзначного числа не одинаковые
            }
        }
    }
}