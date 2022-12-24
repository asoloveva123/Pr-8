using System;

namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: "); //Ввод значения x
            double x = double.Parse(Console.ReadLine());
            double y = x > 6.7 ? 4 - Math.Exp(4 * x) : Math.Log(3.5 + x);
            Console.WriteLine($"Результат = {y}"); //Вычисление и вывод результата на экран
        }
    }
}