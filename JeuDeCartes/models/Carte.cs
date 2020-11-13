using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeCartes.models
{
    public class Carte
    {
        protected int cout;

        public virtual void afficher()
        {
            Console.WriteLine($"Cout : {this.cout}€"); 
        }
    }
}
