namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем двумерный массив размером 5x10
            double[,] A = new double[5, 10];

            // Вводим элементы массива с клавиатуры
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"Введите элемент A[{i},{j}]: ");
                    A[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Вычисляем сумму и произведение элементов каждой строки
            for (int i = 0; i < 5; i++)
            {
                double sum = 0;
                double product = 1;

                for (int j = 0; j < 10; j++)
                {
                    sum += A[i, j];
                    product *= A[i, j];
                }

                Console.WriteLine($"Сумма элементов строки {i + 1}: {sum}");
                Console.WriteLine($"Произведение элементов строки {i + 1}: {product}");
            }
        }
    }
}