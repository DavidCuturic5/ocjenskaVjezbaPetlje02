using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocjenskaVjezbaPetlje02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite niz znakova:");
            string niz = Console.ReadLine();

            char najcesciZnak = '\0';
            int maxPojavljivanja = 0;

            
            for (int i = 0; i < niz.Length; i++)
            {
                char trenutniZnak = niz[i];

               
                int brojPojavljivanja = niz.Split(trenutniZnak).Length - 1;

                if (brojPojavljivanja > maxPojavljivanja)
                {
                    najcesciZnak = trenutniZnak;
                    maxPojavljivanja = brojPojavljivanja;
                }
            }

            Console.WriteLine("Najcesci znak je " +najcesciZnak + " i pojavljuje se " + maxPojavljivanja + " " + "puta");

            Console.ReadKey();
        }


    }
    
}
