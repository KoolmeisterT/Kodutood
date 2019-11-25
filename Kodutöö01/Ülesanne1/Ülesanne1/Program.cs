using System;

namespace Ülesanne1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Sisesta esimene arv -> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv -> ");
            b = Convert.ToInt32(Console.ReadLine());
            int sum = a * b;
            Console.WriteLine("Nende arvude korrutis on " + sum);
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();
        }

    }
}
