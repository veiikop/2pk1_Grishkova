namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double n = 0.0;
            double m = 0.0;
            double k;
            if (b > 10.5)
            {
                n = (38 * a) / 13 * (a - b);
            }
            else if (b <= 10.5)
            {
                n = 12 * Math.Cos(0.1 * b);
            }
            if (n <= 2)
            {
                m = Math.Sin(a * Math.Pow(n, 2));
            }
            else if (n > 2)
            {
                m = 21 * a * n + 2.5 * Math.Pow(n, 2);
            }
            k = Math.Pow((a + n), 4) + Math.Pow((b + m), 2);

            Console.WriteLine("n = " + Math.Round(n, 2));
            Console.WriteLine("m = " + Math.Round(m, 2));
            Console.WriteLine("k = " + Math.Round(k, 2));

            Console.ReadLine();
        }
    }
}