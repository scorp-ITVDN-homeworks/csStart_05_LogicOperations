using System;

namespace BitEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine(new string('.', 100));

            x += y >> x++ * z;
            Console.WriteLine("x += y >> x++ * z");
            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine(new string('.', 100));

            z = ++x & y * 5;
            Console.WriteLine("z = ++x & y * 5");
            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine(new string('.', 100));

            y /= x + 5 | z;
            Console.WriteLine("y /= x + 5 | z");
            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine(new string('.', 100));

            z = x++ & y * 5;
            Console.WriteLine("z = x++ & y * 5");
            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine(new string('.', 100));

            x = y << x++ ^ z;
            Console.WriteLine("x = y << x++ ^ z");
            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine(new string('.', 100));

            Console.ReadKey();
        }
    }
}
