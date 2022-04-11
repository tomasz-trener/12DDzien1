using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int wynik = a + b;

            // wersja 1
            //Console.WriteLine("wynik to: "+ wynik);
            //Console.WriteLine("długość to: "+ Convert.ToString(wynik).Length);

            // wersja 2 , taki łamianiec pomieszane stringi i inne elementy 
            string s1 = "Wynik to:" + wynik + " a długośc to: " + Convert.ToString(wynik).Length;
            Console.WriteLine(s1);

            // wersja 3 , uzycie $

            string s2 = $"Wynik to: {wynik} a długość to {Convert.ToString(wynik).Length}";

            // wersja 4 , użycie string.format 

            string s3 = string.Format("Wynik to: {0}, a długość to {1}",
                wynik, Convert.ToString(wynik).Length);

            Console.WriteLine(s3);

            Console.WriteLine("wczytaj sume dwóch liczb"); //23+123
            string rownanie = Console.ReadLine();

            int pozPlus = rownanie.IndexOf('+');
            //12+123
            //012345
            int a1 = Convert.ToInt32(rownanie.Substring(0, pozPlus));
            int a2 = Convert.ToInt32(rownanie.Substring(pozPlus+1));

           // int a3 = Convert.ToInt32("+5");

            Console.WriteLine($"Wynik to {a1+a2}");

            Console.ReadKey();
        }
    }
}
