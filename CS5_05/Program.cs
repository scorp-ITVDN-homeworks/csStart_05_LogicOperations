using System;

namespace CS5_05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool process = true;

            while (process)
            {
                Console.WriteLine("Введите два целых числа. " +
                "Будут выведены все чётные числа\n" +
                "в диапазоне между двумя заданными числами.\n" +
                "Первое число:");

                int startNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Второе число");

                int endNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(new string('-', Console.WindowWidth) + "\n");

                for (int i = startNumber; i <= endNumber; i++)
                {
                    int check = i & 1;
                    if (check == 0) Console.WriteLine(i);
                }

                Console.WriteLine(new string('-', Console.WindowWidth) + "\n");

                Console.WriteLine("Повторить? (да/нет)");
                process = Console.ReadLine() == "да" ? true : false;

                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
