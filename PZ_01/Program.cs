namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a ");  
            double a = double.Parse(Console.ReadLine());  //ввод значения с клавиатуры

            Console.WriteLine("Введите число b ");
            double b = double.Parse(Console.ReadLine());  //ввод значения с клавиатуры

            double c = (Math.PI) / 4; //присваивание переменной значения

            double num1, num2, num3; //делим выражение на две части для удобства работы с ним

            num1 = Math.Pow((a - 1), 1/3);  //вычисления

            num2 = Math.Pow((b + num1), 1/4); //вычисления

            num3 = (Math.Abs(a - b)) * (Math.Pow(Math.Sin (c), 2) + Math.Tan(c)); //вычисления

            double result = num2 / num3;  //создание переменной результата
            Console.WriteLine("Результат " + result);  //вывод результата на экран

            Console.ReadLine();

        }
    }
}