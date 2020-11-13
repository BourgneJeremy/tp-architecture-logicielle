using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeCartes.models
{
    public class Terrain : Carte
    {
        Couleur couleur = new Couleur();
        public Terrain(int cout, char couleurChoisie)
        {
            this.cout = cout;
            couleur.SetCouleur(couleurChoisie);
        }

        public override void afficher()
        {
            Console.WriteLine($"Coût : {cout}; " +
                $"Couleur choisie: {couleur.GetNomCouleur()}");
        }
    }
}
