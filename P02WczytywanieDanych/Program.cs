using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WczytywanieDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dzien dobry, jak sie nazywasz?");

            string imie= Console.ReadLine();

            imie = imie + " " + imie;
            Console.WriteLine(imie);


            Console.WriteLine("Ile masz lat");

            //wersja 1
            //  string wiek = Console.ReadLine();
            //  int wiek2 = Convert.ToInt32(wiek);
            // wersja2 

            int wiek = Convert.ToInt32(Console.ReadLine());

            wiek++; // zwiejkszenie o 1 

            //  Console.WriteLine("Twoj wiek to " + Convert.ToString(wiek));
            string s = "Twoj wiek to " + wiek;
            Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}
