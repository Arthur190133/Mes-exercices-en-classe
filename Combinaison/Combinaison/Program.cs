using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinaison
{
    class Program
    {

        static void trouver_couleur(ref int[] combi)
        {
            Random rnd = new Random();

            for (int n = 0; n < combi.Length ; n++)
            {
                combi[n] = rnd.Next(1, 7);
                

            }
            
           

        }
        static void afficher(ref int[] combi)
        {
            for(int n = 0; n < combi.Length; n++)
            {
                Console.WriteLine(combi[n]);
            }
        }



        static void Main(string[] args)
        {

            int[] combi = new int [4] ;


            trouver_couleur(ref combi);

            afficher(ref combi);


            Console.WriteLine("Voici toutes les couleurs");
            Console.ReadLine();




        }
    }
}
