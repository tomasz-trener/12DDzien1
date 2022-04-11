using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12ZadaniePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WCzytaj dowolne zdanie");
            string zdanie = Console.ReadLine();

            Console.WriteLine("wczytaj dowolny znak");
            string znak = Console.ReadLine();

            int suma = 0;
            int i = 0;
            //ala
            //012   długosc=3
            while (i<zdanie.Length)
            {
                string ityZnak = zdanie.Substring(i, 1);
                if (ityZnak == znak)
                    suma++;

                i++;
            }

            Console.WriteLine("Liczba znakow: " + suma);


            // wersja rozszerzona 
            Console.WriteLine("Wczytaj szukany wyraz");
            string wyraz = Console.ReadLine();
            i = 0;
            suma = 0;

            //ala ma kota          a my szukamy ma
            //ma
            //012345678910

            // 11-2+1    (dlugoscCalosci-dlugoscWyrazu+1 (przesuniecie wzgledem 0)

            while (i<zdanie.Length-wyraz.Length+1)
            {
                string ityWyraz = zdanie.Substring(i, wyraz.Length);
                if (ityWyraz == wyraz)
                    suma++;

                i++;
            }

            Console.WriteLine($"Wyraz {wyraz} został znaleziony {suma} razy");


            Console.ReadKey();
        }
    }
}
