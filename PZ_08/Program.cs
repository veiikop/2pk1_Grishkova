namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Генерация ступенчатого массива символов
            Random random = new Random();
            int rows = 9;
            char[][] jaggedArray = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                int length = random.Next(10, 35); // Генерация случайной длины строки от 10 до 35
                jaggedArray[i] = new char[length];
                for (int j = 0; j < length; j++)
                {
                    jaggedArray[i][j] = (char)random.Next('A', 'Z' + 1); // Генерация случайного символа от A до Z
                }
            }

            // Вывод ступенчатого массива в консоль
            foreach (char[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // Создание нового одномерного массива с последними элементами каждой строки
            char[] lastElements = new char[rows];
            for (int i = 0; i < rows; i++)
            {
                lastElements[i] = jaggedArray[i].Last();
            }

            // Вывод нового одномерного массива в консоль
            Console.WriteLine(string.Join(" ", lastElements));

            // Нахождение максимального элемента в каждой строке и запись их в другой одномерный массив
            int[] maxElements = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                maxElements[i] = jaggedArray[i].Max();
            }

            // Вывод массива максимальных элементов в консоль
            Console.WriteLine(string.Join(" ", maxElements));

            // Замена первого элемента и максимального элемента в каждой строке
            for (int i = 0; i < rows; i++)
            {
                int maxIndex = Array.IndexOf(jaggedArray[i], maxElements[i]);
                char temp = jaggedArray[i][0];
                jaggedArray[i][0] = jaggedArray[i][maxIndex];
                jaggedArray[i][maxIndex] = temp;
            }

            // Вывод обновленного ступенчатого массива в консоль
            foreach (char[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // Реверс каждой строки ступенчатого массива
            for (int i = 0; i < rows; i++)
            {
                Array.Reverse(jaggedArray[i]);
            }

            // Вывод реверсированного ступенчатого массива в консоль
            foreach (char[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // Подсчет наиболее встречающихся символов в каждой строке
            foreach (char[] row in jaggedArray)
            {
                var mostFrequentChars = row.GroupBy(c => c).OrderByDescending(g => g.Count()).Select(g => g.Key).Take(3);
                Console.WriteLine(string.Join(" ", mostFrequentChars));
            }

            Console.ReadLine();
        }
    }
}