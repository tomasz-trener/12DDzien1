using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int a = 1;
            ////Console.WriteLine(a);

            ////a++;
            ////Console.WriteLine(a);

            ////a++;
            ////Console.WriteLine(a);

            // breake
            Console.WriteLine("---- break----");
            int i = 1;
            while (true)
            {
                if (i == 5)
                    break;

                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine(i);

            Console.WriteLine(  "---- continue----");
            // continue 
            i = 1;

            while (i<10)
            {
                if(i==5)
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i);
                i++;
            }




            Console.ReadKey();


        }
    }
}
