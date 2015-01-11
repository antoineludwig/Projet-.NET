using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace CompilJeux
{
    public class Carte
    {
        public int valeur { get; set; }
        public couleurs couleur { get; set; }
        public Bitmap imagecarte;
        public int puissance; 

        public enum couleurs
        {
            PIQUE,
            TREFLE,
            COEUR,
            CARREAU,
            DOS
        }

        public Carte(Bitmap img, couleurs c, int v,int pui)
        {
            imagecarte = new Bitmap(img);
            couleur = c;
            valeur = v;
            puissance = pui;

        }

        public Carte(Carte c)
        {
            imagecarte = c.imagecarte;
            couleur = c.couleur;
            valeur = c.valeur;
            puissance = c.puissance;
        }

        public Carte()
        {
            imagecarte = CompilJeux.Properties.Resources.dos_01_img;
            couleur = couleurs.DOS;
            valeur = 0;
            puissance = 0;
        }

        public void DebugAffiche()
        {
            Debug.Write(valeur + " de " + couleur + " puissance " + puissance + "\n");
        }

    }
}
