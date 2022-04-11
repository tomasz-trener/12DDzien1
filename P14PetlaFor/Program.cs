using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14PetlaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---petla 1 ---");
            int i = 0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("---petla 2 ---");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("---petla 3 ---");
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("---petla 4 ---");
            for (int j = 10; j >0; j--)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("---petla 5 ---");
            for (int j = 2; j < 10000; j=j*j)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();


            //Console.WriteLine(j);


        }
    }
}
