using System;
using System.IO;

namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = @"input.txt"; //создаем два пути к нашим двум файлам
            string output = @"output.txt";
            int num, max_num, min_num; //вспомогательные переменные
            Random rand = new Random(); //переменная типа Random для заполнения файла случайными числами
            using (FileStream file = new FileStream(input, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    for (int i = 0; i < 100; i++)  // заполняем наш файл случайными числами
                    {
                        num = rand.Next(0, 100);
                        writer.WriteLine(num);
                    }
                }
                string[] nums = File.ReadAllLines(input); //создаем массив строк и заполняем его строками из нашего файла

                Console.WriteLine("Ваш файл заполнился случайными числами от 1 до 100!");

                max_num = Convert.ToInt32(nums.Max()); //находим максимальное и минимальное число в массиве и присваиваем их нашим переменным
                min_num = Convert.ToInt32(nums.Min()); //попутно конвертируя значения в Int32, т.к. выше создали массив строк
            }

            using (FileStream file1 = new FileStream(output, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamWriter writer1 = new StreamWriter(file1))
                {
                    writer1.WriteLine(max_num); //записываем в наш новый файл максимальное и минимальное число
                    writer1.WriteLine(min_num);

                    Console.WriteLine($"Максимальное число в файле: {max_num}\nМинимальное число в файле: {min_num}");
                }
            }
        }
    }
}