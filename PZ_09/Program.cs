namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из слов, разделенных пробелами:");
            string input = Console.ReadLine();

            string firstWord = GetFirstWord(input);
            string lastWord = GetLastWord(input);
            string middleWords = GetMiddleWords(input);

            string output = lastWord + middleWords + firstWord;

            Console.WriteLine("Результат: " + output);
        }

        static string GetFirstWord(string input)
        {
            int spaceIndex = input.IndexOf(' ');
            return input.Substring(0, spaceIndex) + " ";
        }

        static string GetLastWord(string input)
        {
            int spaceIndex = input.LastIndexOf(' ');
            return input.Substring(spaceIndex + 1) + " ";
        }

        static string GetMiddleWords(string input)
        {
            int firstSpaceIndex = input.IndexOf(' ');
            int lastSpaceIndex = input.LastIndexOf(' ');
            return input.Substring(firstSpaceIndex + 1, lastSpaceIndex - firstSpaceIndex - 1);
        }
    }
}