namespace PZ_11
{
    internal class Program
    {
        static void GetMax(int[] numbers, out int maxValue)
        {
            maxValue = int.MinValue;
            foreach (int number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 21, 7, 11, 89, 4 };
            int maxValue;
            GetMax(numbers, out maxValue);
            Console.WriteLine("Max value: " + maxValue);
        }
    }
}