using System;

namespace Kodutöö01
{
    class Program
    {
        static void Main(string[] args)
        {
            A06();
            Console.Write("\nVajuta suvaline klahv\n");
            Console.ReadKey();
        }

        static void A01()
        {
            int a, b;
            Console.WriteLine("Sisesta esimene arv -> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv -> ");
            b = Convert.ToInt32(Console.ReadLine());
            int sum = a * b;
            Console.WriteLine("Nende arvude korrutis on " + sum);
        }

        static void A02()
        {
            int n, i;
            Console.WriteLine("Sisesta arv, millega soovid korrutised teha. ");
            n = Int32.Parse(Console.ReadLine());
            for (i = 1; i <= 10; ++i)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
        }

        static void A03()
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
        }

        static void A04()
        {
            Console.WriteLine("Sisesta temperatuur Celsiuses: ");
            int Celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fahrenheitis on see {0}", Celsius * 18 / 10 + 32);
        }

        static void A05()
        {
            Console.WriteLine("Sisesta temperatuur Fahrenheitis: ");
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Celsiuses on see {0}", (Fahrenheit - 32) / 1.8);
        }

        static void A06()
        {
            float a, b, tulemus;
            Console.WriteLine("Sisesta esimene arv -> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv -> ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta tehe (+, -, *, /) ");
            string tehe = Console.ReadLine();
            if (tehe == "+")
            {
                tulemus = a + b;
                Console.WriteLine(a + " + " + b + " = " + tulemus);
                Console.Write("\nVajuta suvaline klahv\n\n");
                Console.ReadKey();
            }

            else if (tehe == "-")
            {
                tulemus = a - b;
                Console.WriteLine(a + " - " + b + " = " + tulemus);
                Console.Write("\nVajuta suvaline klahv\n\n");
                Console.ReadKey();
            }

            else if (tehe == "*")
            {
                tulemus = a * b;
                Console.WriteLine(a + " * " + b + " = " + tulemus);
                Console.Write("\nVajuta suvaline klahv\n\n");
                Console.ReadKey();
            }

            else if (tehe == "/")
            {
                tulemus = a / b;
                Console.WriteLine(a + " / " + b + " = " + tulemus);
            }

        }
    }
}
