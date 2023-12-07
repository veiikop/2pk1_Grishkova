using System;
using System.IO;

namespace PZ_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к каталогу:");
            string path = Console.ReadLine();

            try
            {
                // Создаем подкаталог TEMP
                string tempPath = Path.Combine(path, "TEMP");
                Directory.CreateDirectory(tempPath);

                // Получаем список файлов в каталоге
                string[] files = Directory.GetFiles(path);

                // Переносим файлы в TEMP
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(tempPath, fileName);
                    File.Move(file, destFile);
                }

                Console.WriteLine("Файлы успешно перемещены в папку TEMP");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}