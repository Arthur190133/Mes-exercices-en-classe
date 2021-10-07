using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categorie_sportive
{
    class Program
    {

        static void Trouver_cat(int age_enfant, out string Cat_sport)
        {
            if (age_enfant >= 6  &&  age_enfant  <= 14)
            {
                if (age_enfant >= 12)
                {
                    Cat_sport = "Votre enfant appartient à la catégorie : Cadet ";
                }
                else
                {
                    if (age_enfant >= 10)
                    {
                        Cat_sport = "Votre enfant appartient à la catégorie : Mimine ";
                    }
                    else
                    {
                        if (age_enfant >= 8)
                        {
                            Cat_sport = "Votre enfant appartient à la catégorie : Pupille ";
                        }
                        else
                        {
                            Cat_sport = "Votre enfant appartient à la catégorie : Poussin ";
                        }
                    }
                }
            }
            else
            {
                Cat_sport = "Votre enfant de peux pas accèder à une catégorie sportive";
            }
        }
        static void Main(string[] args)
        {
            int age_enfant;
            string Cat_sport;

            Console.WriteLine("Entrez l'age de l'enfant");
            age_enfant = Convert.ToInt32(Console.ReadLine());

            Trouver_cat(age_enfant, out Cat_sport);

            Console.WriteLine(Cat_sport);
            Console.ReadLine();

        }
    }
}
