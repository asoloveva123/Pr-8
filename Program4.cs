using System;

namespace aip;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите N судей= "); //ввод количества судей
        int n = int.Parse(Console.ReadLine());

        double[] marks = new double[n];

        double max = 0;
        double min = 0;

        for(int i = 0; i < n; i++)
        {
            marks[i] = new Random().Next(10);
        }

        min = marks[0];

        for (int i = 0; i < n ; i++)
        {
            if (marks[i] > max)
                max = marks[i];
        }

        int count = 0;
        double sum = 0;

        for(int i = 0; i< n ; i++)
        {
            if (marks[i] != min && marks[i] != max)
            {
                count++;
                sum += marks[i];
            }
        }
        Console.WriteLine("Среднее арифметическое оценок = {0}", sum/ count); //вывод на экран среднего арифметического оценок
    }
}