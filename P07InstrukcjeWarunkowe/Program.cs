using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek");
            int wiek = Convert.ToInt32(Console.ReadLine());

            bool czyMlody = wiek < 60;

            if (czyMlody) //wiek < 60
                Console.WriteLine("Młody");
            else
            {
                string ss = "starszy";
                Console.WriteLine(ss);
            }

            if (wiek < 20)
                Console.WriteLine("barzdo mlody");
            else if (wiek < 60)
                Console.WriteLine("młody");
            else
                Console.WriteLine("starszy");

            // instrukcje warunkowe mozna zgniezdzac 

            if(wiek > 20)
                if(wiek<60)
                    Console.WriteLine("sredni");
                else
                    Console.WriteLine("starszy");
            else
                Console.WriteLine("młodszy");


            string typ;
            if (wiek < 60)
                typ = "Młody";
            else
                typ = "Straszy";

            string typ2 = wiek < 60 ? "Młody" : "Starszy";

            string typ3 = wiek < 60 ? (wiek < 20 ? "Młody" : "Sredni") : "Straszy";







        }
    }
}
