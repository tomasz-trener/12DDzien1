using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15PrzechwytywanieBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); 

            int b = Convert.ToInt32(Console.ReadLine());
           
            int? a=null;
            try
            {
                a = Convert.ToInt32(s);              
                int c = 10 / b;       
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie podawaj nigdy 0!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Podaj liczbe a nie tekst");
            }
            catch (Exception)
            {
                Console.WriteLine("Wsytapil jakis blad");
            }

            if (a != null)
                Console.WriteLine(a);

            Console.WriteLine("program działa dalej");
            
            Console.ReadKey();





        }
    }
}
