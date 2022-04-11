using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03OperacjeNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota";

            int dlugosc = s.Length;

            string w1 = s.Substring(4);// od czwartego znaku do konca : ma kota
            string w2 = s.Substring(4, 2); // ma

            string w3 = s.Replace("ma", "bedzie miała"); // ala bedzie miała kota 

            bool w4 =  s.Contains("ma"); // tak lub nie 

            string w5 = s.ToUpper();
            string w6 = s.ToLower(); // zamiana na duze i na male literki 

            int w7= s.IndexOf("ma"); // na której pozycji jest pierwsze wystapienie napisu "ma", u nas to 4 



           // Console.WriteLine(w3);
           // Console.ReadKey();



        }
    }
}
