using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09PytanieIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota i ma psa"; // szukamy ma 

            //a++  najpierw uzyj zmiennej a potem zwieksz o 1 
            //++a  najpierw zwieksz o 1 a potem uztj zmiennej 

            int a= s.IndexOf("ma"); // tutaj znajduje pozcje u nas 4
            a++;
            int drugieA=  s.Substring(a).IndexOf("ma");

            // w tym momencie  a = 5

            // wniosek ogólny: chociaż mozliwe jest korzystanie z konstrukcji a++ i ++a podczas przekazywanai argurmntów do funkcji to nie jest to
            // czytelne i może komplikować zrozumienie kodu 
            // dobre programoawnie to nie konkurs na najkrótzsy kod 

            s = s
                .Replace("1", "")
                .Replace("2", "")
                .Replace("3", "")
                .Replace("4", "")
                .Replace("5", "")
                .Replace("6", "")
                .Replace("7", "")
                .Replace("8", "")
                .Replace("9", "")
                .Replace("0", "");



        }
    }
}
