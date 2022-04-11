using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Debugowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mamy 2 rodzaje błedów
            // 1) bład na etapie komplikacji
            // 2) bląd na etapie wykonynwania programu


            string s = "5";

            int a = Convert.ToInt32(s);

            a = a + 5;
            a++; // zwieksz o 1 
            a += 7; // zwieksz o dowolna watosc  to samo co a=a+7

            a -= 2;// zmniejsz o 2 

            a *= 4;// przemnoz przez 4, a=a*4
            a /= 2;

            Console.WriteLine(a);

            Console.ReadKey();



        }
    }
}
