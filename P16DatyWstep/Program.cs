using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16DatyWstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "12.01.2022";

            DateTime d = new DateTime(2022, 1, 12);

            d= d.AddMonths(2);


            Console.WriteLine(d.ToString("dd-MM-yyyy"));
        }
    }
}
