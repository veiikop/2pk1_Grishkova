namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму покупки: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите номер дня недели: ");

            int day = Convert.ToInt32(Console.ReadLine());
            double result = 0.0;
            switch (day)
            {
                case 1:
                    result = sum - (sum / 100 * 3);
                    Console.WriteLine("Размер скидки 3%");
                    Console.WriteLine("Сумма со скидкой: " + result);
                    break;
                case 2:
                    goto case 1;
                case 3:
                    goto case 1;
                case 4:
                    goto case 1;
                case 5:
                    goto case 1;

                case 6:
                    result = sum - (sum / 100 * 7);
                    Console.WriteLine("Размер скидки 7%");
                    Console.WriteLine("Сумма со скидкой: " + result);
                    break;
                case 7:
                    goto case 6;
            }
        }
    }
}