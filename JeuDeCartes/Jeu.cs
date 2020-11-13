using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeCartes.models
{
    public class Jeu
    {
        private List<Carte> listeCartes;

        public Jeu(int nbCartes)
        {
            listeCartes = new List<Carte>(nbCartes);
        }

        public void Piocher(Carte carte)
        {
            listeCartes.Add(carte);
            Console.WriteLine("----------------PIOCHE-------------------");
            Console.WriteLine("La carte ci-dessous à été ajouté au deck");
            carte.afficher();
        }

        public void Joue()
        {
            Random rnd = new Random();
            int card = rnd.Next(listeCartes.Count);
            Console.WriteLine("----------------CARTE JOUÉE-------------------");
            Console.WriteLine("La carte ci-dessous à été jouée");

            listeCartes[card].afficher();
        }

        public void AfficherDeck()
        {
            Console.WriteLine("----------------MON DECK-------------------");
            foreach (var item in listeCartes)
            { 
                Console.WriteLine($"Type : {item.GetType().Name}");
                item.afficher();
                Console.WriteLine("-----");
            }
        }
    }
}
