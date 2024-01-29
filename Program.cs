using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:");
            string nizZnakova = Console.ReadLine();

            char najcesciZnak = PronadjiNajcesciZnak(nizZnakova, out int brojPojavljivanja);

            Console.WriteLine($"Najcesci znak je: {najcesciZnak}");
            Console.WriteLine($"Broj pojavljivanja: {brojPojavljivanja}");
        }

        static char PronadjiNajcesciZnak(string nizZnakova, out int brojPojavljivanja)
        {
            int[] brojac = new int[256]; // Pretpostavljamo ASCII znakove

            foreach (char znak in nizZnakova)
            {
                brojac[znak]++;
            }

            char najcesciZnak = ' ';
            brojPojavljivanja = 0;

            for (int i = 0; i < 256; i++)
            {
                if (brojac[i] > brojPojavljivanja)
                {
                    najcesciZnak = (char)i;
                    brojPojavljivanja = brojac[i];
                }
            }
            Console.ReadKey();

            return najcesciZnak;
        }
    }
}
