using System;

namespace Koolmeister_Tiina_Kodutöö1
{
    class Program
    {
        static void Main(string[] args)
        {
            YLaa();
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();
            YLbb();
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();
            YLcc();
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();
        }

        static void YLaa()
        {
            int kogupikkus, poolpikkus, poolvarvi, koguvarv, veelvarvi;
            kogupikkus = 56;
            poolpikkus = 22;
            Console.Write("Mitu kg värvi kulus 22 m kooli koridori põranda värvimiseks? ");
            poolvarvi = Convert.ToInt32(Console.ReadLine());
            koguvarv = kogupikkus * poolvarvi / poolpikkus;
            veelvarvi = koguvarv - poolvarvi;
            Console.Write("Kui kooli koridori pikkus on 56 m, siis koridori põranda lõpuni värvimiseks on vaja veel {0} kg värvi", veelvarvi);
        }

        static void YLbb()
        {
            float traatA, traatAkaal, traatC, traatCkaal, traatMkaal;
            traatAkaal = 430;
            Console.Write("Kui pikk traat kaalub 430 g? ");
            traatA = Convert.ToSingle(Console.ReadLine());
            Console.Write("Kui pikka traati on vaja tööks? ");
            traatC = Convert.ToSingle(Console.ReadLine());
            Console.Write("Kui palju kaalub olemasolev traadirull? ");
            traatMkaal = Convert.ToSingle(Console.ReadLine());
            traatCkaal = traatAkaal * traatC / traatA;
            if (traatCkaal <= traatMkaal)
                Console.Write("Olemasolevast traadirullist piisab töö valmistamiseks!");
            else
                Console.WriteLine("Olemasolevast traadirullist ei piisa töö valmistamiseks!");
        }

        static void YLcc()
        {
            int arv, summa;
            summa = 0;
            for (arv = 100; arv <= 200; arv++)
                if (arv % 17 == 0)
                {
                    summa = summa + arv;
                }
            Console.Write("Arvude 100 ja 200 vahele jäävate 17-ga jaguvate arvude summa on " + summa);
        }
    }
}
