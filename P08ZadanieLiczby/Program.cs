using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieLiczby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wcztyaj równanie matematyczne");

            string rownanie = Console.ReadLine().Replace(" ",""); // usuwamy spacje od razu  
                                                  // 20-5
                                                  // 0123 (pozycje)

            int pozPlus= rownanie.IndexOf('+');
            int pozMinus = rownanie.IndexOf('-');
            int pozMnozenie = rownanie.IndexOf('*');
            int pozDzielenie = rownanie.IndexOf('/');

            int? wynik=null;
            if(pozPlus > -1)
            {
                int liczba1 = Convert.ToInt32(rownanie.Substring(0, pozPlus));
                int liczba2 = Convert.ToInt32(rownanie.Substring(pozPlus+1));
                wynik = liczba1 + liczba2;
            }
            else if (pozMinus > -1)
            {
                int liczba1 = Convert.ToInt32(rownanie.Substring(0, pozMinus));
                int liczba2 = Convert.ToInt32(rownanie.Substring(pozMinus + 1));
                wynik = liczba1 - liczba2;
            }
            else if (pozMnozenie > -1)
            {
                int liczba1 = Convert.ToInt32(rownanie.Substring(0, pozMnozenie));
                int liczba2 = Convert.ToInt32(rownanie.Substring(pozMnozenie + 1));
                wynik = liczba1 * liczba2;
            }
            else if (pozDzielenie > -1)
            {
                int liczba1 = Convert.ToInt32(rownanie.Substring(0, pozDzielenie));
                int liczba2 = Convert.ToInt32(rownanie.Substring(pozDzielenie + 1));
                wynik = liczba1 / liczba2;
            }
           
            if(wynik != null)
                Console.WriteLine(wynik);
            else
                Console.WriteLine("Podałeś nieznany operator");
            
            Console.ReadKey();


            bool? logiczna = null;
            // int ,char, long, short , not nullable
            // string jest nullable 
            string s = null;

            double d = double.NaN; // to jest jeszcze cos innego niz null 
            double d2 = 10;
            double d3 = d2 / 0;// wtnik to NaN // to nie bład (program się nie zawiesi ) 

            double licznaNiecalkowita = 5.6; // double to liczna niecalkowita 

            int liczbaCalkowita = 5; // liczba całkowita 
            double? liczba = null;


        }
    }
}
