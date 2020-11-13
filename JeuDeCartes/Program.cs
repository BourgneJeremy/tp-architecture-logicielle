using System;
using JeuDeCartes.models;

namespace JeuDeCartes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jeu monJeuDeCartes = new Jeu(10);

            monJeuDeCartes.Piocher(new Terrain(31, 'r'));
            monJeuDeCartes.Piocher(new Creature(20, "Tarik", 25, 15));
            monJeuDeCartes.Piocher(new Sortilege(20, "Lancer de flammes", "Lance des flammes ravageuses"));

            monJeuDeCartes.AfficherDeck();

            monJeuDeCartes.Joue();
        }
    }
}
