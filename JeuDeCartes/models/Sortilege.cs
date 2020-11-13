using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeCartes.models
{
    public class Sortilege : Carte
    {
        private string nom;
        private string description;

        public Sortilege(int cout, string nom, string description)
        {
            this.cout = cout;
            this.nom = nom;
            this.description = description;
        }

        public override void afficher()
        {
            Console.WriteLine($"Coût : {cout}; " +
                $"Nom : {nom}; " +
                $"Description : {this.description};");
        }
    }
}
