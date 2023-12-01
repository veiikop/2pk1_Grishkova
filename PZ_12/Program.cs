namespace PZ_12
{
    internal class Program
    {
        public static string FormatFullName(string fullName)
        {
            string[] parts = fullName.Split(' ');
            // разбиваем строку на части по пробелам
            string lastName = parts[0].Substring(0, 1).ToUpper() + parts[0].Substring(1); 
            // получаем фамилию с заглавной буквы
            string firstName = parts[1].Substring(0, 1).ToUpper() + "."; 
            // получаем первую букву имени и добавляем точку
            string middleName = parts[2].Substring(0, 1).ToUpper() + "."; 
            // получаем первую букву отчества и добавляем точку
            return $"{lastName} {firstName}{middleName}";
            // склеиваем все части в одну строку и возвращаем ее
        }
        static void Main(string[] args)
        {
            Console.Write("Введите ФИО студента: ");
            string fullName = Console.ReadLine();
            string formattedName = FormatFullName(fullName);
            Console.WriteLine($"Отформатированное ФИО: {formattedName}");
        }
    }
}