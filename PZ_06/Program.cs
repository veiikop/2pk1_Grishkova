namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            // Заполнение массива случайными числами от -50 до 49
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
            }

            int sumOfNegatives = 0;
            int minPositive = int.MaxValue;

            // Нахождение суммы отрицательных элементов и минимального положительного элемента
            foreach (int number in array)
            {
                if (number < 0)
                {
                    sumOfNegatives += number;
                }
                else if (number > 0 && number < minPositive)
                {
                    minPositive = number;
                }
            }

            // Прибавление минимального положительного элемента к сумме отрицательных элементов, если она меньше -100
            if (sumOfNegatives < -100)
            {
                sumOfNegatives += minPositive;
            }

            Console.WriteLine("Сумма отрицательных элементов: " + sumOfNegatives);
        }
    }
}