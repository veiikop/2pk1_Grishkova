namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы ");
            string text = Console.ReadLine();
            int length = text.Length;
            if (length % 2 == 0)
            {
                // количество символов чётное, найдем два символа посередине
                int middle = length / 2;
                char middleChar1 = text[middle - 1];
                char middleChar2 = text[middle];
                Console.WriteLine("Символы посередине: {0}, {1}", middleChar1, middleChar2);
            }
            else
            {
                // количество символов нечётное, найдем символ посередине
                int middle = length / 2;
                char middleChar = text[middle];
                Console.WriteLine("Символ посередине: {0}", middleChar);
            }
        }
    }
}