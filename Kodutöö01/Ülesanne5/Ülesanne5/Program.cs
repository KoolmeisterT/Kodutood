using System;

namespace Ülesanne5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sisesta temperatuur Fahrenheitis: ");
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Celsiuses on see {0}", (Fahrenheit - 32) / 1.8);
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();
        }
    }
}
