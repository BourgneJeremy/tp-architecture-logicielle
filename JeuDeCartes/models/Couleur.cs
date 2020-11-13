using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeCartes.models
{
    public class Couleur
    {
        private char couleur;

        public void SetCouleur(char couleur) => this.couleur = couleur;
        public char GetCouleur() => couleur;
        public string GetNomCouleur() {
            switch (couleur)
            {
                case 'B':
                    return "Blanc";
                case 'b':
                    return "Bleu";
                case 'n':
                    return "Noir";
                case 'r':
                    return "Rouge";
                case 'v':
                    return "Vert";
                default:
                    return "Erreur, aucune couleur n'a été trouvée";
            }
        }
    }
}
