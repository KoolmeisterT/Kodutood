using System;

namespace Ülesanne6
{
    class Program
    {
        static void Main()
        {
            int a, b, tulemus;
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
                Console.Write("\nVajuta suvaline klahv\n\n");
                Console.ReadKey();
            }
        }
    }
}
