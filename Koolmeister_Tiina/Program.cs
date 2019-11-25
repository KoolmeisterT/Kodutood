using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koolmeister_Tiina
{
    class Program
    {
        static void Main(string[] args) //mis formaadis edastatakse...void - tühi pm (ei esita teda mingis programmis)
        {
            A07();
            Console.Write("\nVajuta suvaline klahv\n");
            Console.ReadKey();
        }

        static void A01()
        {
            // selle märgiga saab kirjutada kommentaare. /* koodiread */ saab suure osa kommentaariks muuta
            //Algoritm 1

            int arv1, arv2, tulemus;
            Console.Write("Sisesta esimene arv --> ");
            string tekst = Console.ReadLine();
            arv1 = Convert.ToInt32(tekst);
            Console.Write("Sisesta teine arv --> ");
            arv2 = Convert.ToInt32(Console.ReadLine());
            tulemus = arv1 + arv2;
            Console.Write("\nArvude summa on {0}\n\n", tulemus);
            Console.Write("{0} + {1} = {2}\n", arv1, arv2, tulemus);
            Console.Write("{0} - {1} = {2}\n", arv1, arv2, arv1 - arv2);
            Console.Write("{0} x {1} = {2}\n", arv1, arv2, arv1 * arv2);
            Console.Write("{0} : {1} = {2}\n", arv1, arv2, arv1 / arv2);
            Console.Write("{0} jaak {1} = {2}\n", arv1, arv2, arv1 % arv2);
        }

        static void A02()
        {
            //Algoritm 2

            int arv1, arv2;
            Console.Write("Sisesta esimene arv --> ");
            arv1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sisesta teine arv --> ");
            arv2 = Convert.ToInt32(Console.ReadLine());
            if (arv1 > arv2)
            {
                Console.WriteLine("Esimene arv on suurem");
            }
            else
            {
                if (arv2 > arv1)
                    Console.WriteLine("Teine arv on suurem");
                else
                    Console.WriteLine("Arvud on võrdsed");
            }
        }

        static void A05()
        {
            //Algoritm 5

            int arv1, arv2, arv3, suurem;
            Console.Write("Sisesta esimene arv --> ");
            arv1 = Convert.ToInt32(Console.ReadLine());
            suurem = arv1;
            Console.Write("Sisesta teine arv --> ");
            arv2 = Convert.ToInt32(Console.ReadLine());
            if (arv2 > suurem)
                suurem = arv2;
            Console.Write("Sisesta kolmas arv --> ");
            arv3 = Convert.ToInt32(Console.ReadLine());
            if (arv3 > suurem)
                suurem = arv3;
            Console.Write("Suurem = {0}\n", suurem);
        }

        static void A06()
        {
            //Algoritm 6

            int arv, suurem, loendur;
            Console.Write("Sisesta arv 1 --> ");
            arv = Convert.ToInt32(Console.ReadLine());
            suurem = arv;
            for (loendur = 2; loendur <= 6; loendur++)
            {
                Console.Write("Sisesta arv {0} --> ", loendur);
                arv = Convert.ToInt32(Console.ReadLine());
                if (arv > suurem)
                    suurem = arv;
            }
            Console.Write("Suurem = {0}\n", suurem);
        }

        static void A07()
        {
            //Algoritm 7

            float hind, summa = 0; //reaalarvud float (ka single) 4bit (kui ei ole vaja nii väga täpselt) ja double 8bit (kui on vaja rohkem koma kohti, et täpsem oleks)
            int kogus = 0;
            do
            {
                Console.Write("Kauba hind --> ");
                hind = Convert.ToSingle(Console.ReadLine());
                summa += hind; //summa = summa + hind; -> mõlemad õiged. Saab erinevat moodi.
                kogus++; //kogus = kogus + 1; -> mõlemad õiged. Saab erinevat moodi.
            } while (hind > 0);
            kogus--; //kogus = kogus - 1; -> mõlemad õiged. Saab erinevat moodi.
            Console.Write("Ostsite {0} toodet  \n\n", kogus);
            Console.Write("Peate maksma {0} €\n\n", summa);

            float raha, makstud = 0;
            while(makstud<summa)
            {
                Console.Write("Makske --> "); //nendes { sulgudes on tsükkel.
                raha = Convert.ToSingle(Console.ReadLine());
                makstud += raha;
            }
            if (makstud > summa)
                Console.Write("Tagasi saate {0} €\n", makstud - summa);
            else
                Console.WriteLine("Täpne raha!"); //reavahe teeb Writeline,
        }
    }
}
