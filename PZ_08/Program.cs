namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создание ступенчатого массива
            char[][] array = new char[9][];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int length = random.Next(10, 36);
                array[i] = new char[length];

                for (int j = 0; j < array[i].Length; j++)
                {
                    // заполнение массива случайными символами от a до z
                    array[i][j] = (char)random.Next('a', 'z' + 1);
                }
            }

            // вывод сгенерированного массива
            Console.WriteLine("Исходный массив:");
            foreach (char[] row in array)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // создание нового одномерного массива и запись последних элементов каждой строки
            char[] lastElements = new char[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                lastElements[i] = array[i][array[i].Length - 1];
            }

            // вывод нового массива
            Console.WriteLine("\nМассив последних элементов:");
            Console.WriteLine(string.Join(" ", lastElements));

            // поиск максимальных элементов в каждой строке и запись их в новый массив
            char[] maxElements = new char[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                char maxElement = array[i][0];

                for (int j = 1; j < array[i].Length; j++)
                {
                    if (array[i][j] > maxElement)
                    {
                        maxElement = array[i][j];
                    }
                }

                maxElements[i] = maxElement;
            }

            // вывод массива максимальных элементов
            Console.WriteLine("\nМассив максимальных элементов:");
            Console.WriteLine(string.Join(" ", maxElements));

            // замена первого элемента и максимального элемента в каждой строке
            for (int i = 0; i < array.Length; i++)
            {
                char temp = array[i][0];
                array[i][0] = maxElements[i];
                maxElements[i] = temp;
            }

            // вывод обновленного массива
            Console.WriteLine("\nОбновленный массив:");
            foreach (char[] row in array)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // реверс каждой строки ступенчатого массива
            for (int i = 0; i < array.Length; i++)
            {
                Array.Reverse(array[i]);
            }

            // вывод реверсированного массива
            Console.WriteLine("\nРеверсированный массив:");
            foreach (char[] row in array)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // подсчет наиболее встречающихся символов в каждой строке
            Console.WriteLine("\nНаиболее встречающиеся символы в каждой строке:");

            foreach (char[] row in array)
            {
                int[] charCount = new int[26];

                foreach (char c in row)
                {
                    charCount[c - 'a']++;
                }

                int maxCount = charCount[0];
                char mostFrequentChar = 'a';

                for (int i = 1; i < charCount.Length; i++)
                {
                    if (charCount[i] > maxCount)
                    {
                        maxCount = charCount[i];
                        mostFrequentChar = (char)('a' + i);
                    }
                }

                Console.WriteLine("Строка: " + string.Join(" ", row));
                Console.WriteLine("Наиболее встречающийся символ: " + mostFrequentChar);
            }
        }
    }
}