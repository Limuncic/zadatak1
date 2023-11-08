using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Napišite program u kojem ćete deklarirati varijable a, b, c, i d tipa double,
            //te im dodijelite proizvoljne vrijednosti. Deklarirajte varijablu x tipa double kojoj dodijelite vrijednost sljedećeg matematičkog izraza:
            //a2 + b2 + c2 + d2
            //__________________
            //(a + b)2 + (c + d)2

            double a = 3.14, b = 5.8, c = 9.99, d = 99.89;
            double x;
            x = (Math.Pow(a, 2.0) + Math.Pow(b, 2.0) + Math.Pow(c, 2.0) + Math.Pow(d, 2.0)) / (Math.Pow(a + b, 2.0) + Math.Pow(c + d, 2.0));
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
