using System;

namespace Ülesanne4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sisesta temperatuur Celsiuses: ");
            int Celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fahrenheitis on see {0}", Celsius * 18 / 10 + 32);
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();
        }
    }
}
