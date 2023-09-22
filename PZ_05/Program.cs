using System;
using System.Runtime.Intrinsics.X86;

namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процент: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите желаемую сумму цели: ");
            double y = Convert.ToDouble(Console.ReadLine());

            int years = 0;

            do
            {
                x += x * p / 100; // увеличиваем вклад на р процентов
                x = Math.Floor(x); // отбрасываем дробную часть копеек
                years++;
                
            }

            while (x < y);

            Console.WriteLine($"Вклад составит не менее {y} рублей через {years} лет");

        }
    }
}