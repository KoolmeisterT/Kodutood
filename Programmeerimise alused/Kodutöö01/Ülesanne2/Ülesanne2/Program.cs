using System;

namespace Ülesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Sisesta arv, millega soovid korrutised teha. ");
            n = Int32.Parse(Console.ReadLine());
            for (i = 1; i <= 10; ++i)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();
        }
    }
}
