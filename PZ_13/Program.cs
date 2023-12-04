namespace PZ_13
{
    internal class Program
    {
        // задание 1
        static int ArithmeticProgression(int n)
        {
            if (n == 1)
            {
                return 100;
            }
            else
            {
                return ArithmeticProgression(n - 1) + 10;
            }
        }

        // задание 2
        static double GeometricProgression(int n1, double b1, double q)
        {
            if (n1 == 1)
            {
                return b1;
            }
            else
            {
                return GeometricProgression(n1 - 1, b1, q) * q;
            }
        }

        // задание 3
        static void PrintNumbers(int A, int B)
        {
            if (A < B)
            {
                Console.WriteLine(A);
                if (A < B)
                    PrintNumbers(A + 1, B);
            }
            else if (A > B)
            {
                Console.WriteLine(A);
                if (A > B)
                    PrintNumbers(A - 1, B);
            }
            else
            {
                Console.WriteLine(A);
            }
        }

        // задание 4 (на пятерку, №4)
        static void ReverseNumber(int num)
        {
            if (num < 10)
                Console.Write(num);
            else
            {
                Console.Write(num % 10);
                ReverseNumber(num / 10);
            }
        }

        static void Main()
        {
            // 1. вычисляем n-й член арифметической прогрессии с первым членом 100 и разностью 10
            Console.WriteLine("Введите номер члена арифметической прогрессии, который хотите вычислить");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = ArithmeticProgression(n);
            Console.WriteLine("Значение {0}-го члена арифметической прогрессии: {1}", n, result);

            // 2. вычисляем n-й член геометрической прогрессии с первым членом 4 и множителем 0.1
            Console.WriteLine("Введите номер члена геометрической прогрессии, который хотите вычислить");
            int n1 = Convert.ToInt32(Console.ReadLine());
            double b1 = 4; // значение первого элемента
            double q = 0.1; // знаменатель прогрессии
            double result1 = GeometricProgression(n1, b1, q);
            Console.WriteLine("Значение {0}-го члена геометрической прогрессии: {1}", n1, result1);

            // 3. печатаем числа от 5 до 65
            Console.WriteLine("\nВывод чисел от A до B:");
            PrintNumbers(5, 65);

            // 4. обращаем число
            Console.WriteLine("Введите число:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Перевернутое число: ");
            ReverseNumber(number);
        }
    }
}