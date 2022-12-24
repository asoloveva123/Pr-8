using System;

namespace aip;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите x= "); //ввод значения x
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите y= "); //ввод значения y
        double y = double.Parse(Console.ReadLine());

        /* if (x >= -3 && x <= 3 && y <= 3 && y >= 0)
            Console.WriteLine("Точка попадает в заштрихованную область");
           else
            Console.WriteLine("Точка не попадает в заштрихованную область");*/
        double r = Math.Pow(Math.Pow(3, 2) + Math.Pow(3, 2), 0.5);
        double testR = Math.Pow(Math.Pow(x, 2) + Math.Pow(y, 2), 0.5);

        if (testR < r && x >= -3 && x <= 3 && y <= 3 && y >= 0)
            Console.WriteLine("Точка попадает в заштрихованную область"); //вывод на экран, если попадает 
        else
            Console.WriteLine("Точка не попадает в заштрихованную область"); //вывод на экран, если не попадает
    }
}