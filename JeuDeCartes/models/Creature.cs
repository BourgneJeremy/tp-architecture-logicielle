using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeCartes.models
{
    public class Creature : Carte
    {
        private string nom;
        private int ptsDeDegats;
        private int ptsDeVie;

        public Creature(int cout, string nom, int ptsDeDegats, int ptsDeVie)
        {
            this.cout = cout;
            this.nom = nom;
            this.ptsDeDegats = ptsDeDegats;
            this.ptsDeVie = ptsDeVie;
        }
        public override void afficher()
        {
            Console.WriteLine($"Coût : {cout}; " +
                $"Nom : {nom}; " +
                $"Points de dégâts : {ptsDeDegats}; " +
                $"Points de vie : {ptsDeVie}");
        }
    }
}
