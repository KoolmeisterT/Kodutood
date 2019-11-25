using System;

namespace Ülesanne3
{
    class Program
    {
        static void Main()
        {
            double num1, num2, num3;
            Console.WriteLine("Kui soovid leida kolme arvu keskmist, siis sisesta esimene arv ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta kolmas arv ");
            num3 = Convert.ToDouble(Console.ReadLine());

            double tulemus = (num1 + num2 + num3) / 3;
            Console.WriteLine("Nende arvude keskmine on " + tulemus);
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();

        }
    }
}
