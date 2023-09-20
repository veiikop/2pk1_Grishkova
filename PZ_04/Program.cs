namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("число от 0 до 70 с шагом 2");
            for ( int i = 0; i <= 70; i = i + 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            

            // задание 2
            Console.WriteLine("6 символов в алфавитном порядке, начиная с D");
            for (char i = 'D'; i<= 'I'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            

            // задание 3
            Console.WriteLine("5 # значков в 5 строках");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int v = 0; v < 5; v++)
                {
                    Console.Write('#');
                }
            }
            Console.WriteLine();


            // задание 4
            int count = 0;
            Console.WriteLine("значение от 0 до 200, кратное 7");
            for (int i = 0; i <= 200; i++)
            {
                
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("количество чисел кратных '7' равно " + count);
            Console.WriteLine();
            

            //задание 5
            Console.WriteLine("задание 5");
            int a, b;

            for (a = 2, b = 40; b - a > 25; a++, b--)
            {
                Console.WriteLine(a + " " + b);
            }

            Console.WriteLine(a + " " + b);


        }

    }
}