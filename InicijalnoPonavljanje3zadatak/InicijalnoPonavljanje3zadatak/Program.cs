using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje3zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Unesi jedan broj");
            int broj = Convert.ToInt32(Console.ReadLine());

            if (broj % 4 == 0)
            {
                Console.WriteLine("Broj je dijeljiv sa cetiri");
            }
            else if (broj % 6 == 0)
            {
                Console.WriteLine("Broj je dijeljiv sa sest");
            }
            else if (broj % 4 == 0|| broj % 6 == 0)
            {
                Console.WriteLine("Broj je dijeljiv sa cetiri i sa sest");
            }
            Console.ReadKey();
        }
    }
}
