using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13PetlaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "samochod"; // zakładamy, że nasz wyraz skłąda się z przynnjaniej jednej literki

            // co oznacza , ze petla wykona sie przynajniej 1 raz , wtedy mozna skorzystac z petli do while 
            int i = 0;
            do
            {
                Console.WriteLine(s.Substring(i,1));
                i++;
            } while (i<s.Length);

            Console.ReadKey();

        }
    }
}
