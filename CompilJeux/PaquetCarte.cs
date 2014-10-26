using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompilJeux
{
    public class PaquetCarte
    {
        public List<Carte> cartes;

        public PaquetCarte(Dictionary<int,int> lespuissances)
        {

            cartes = new List<Carte>();

            for (int i = 1; i <= 13; i++)
            {
                //récupération des images
                Bitmap imtrefle = (Bitmap)CompilJeux.Properties.Resources.ResourceManager.GetObject("_" +
                i + "_trefle_img");
                Bitmap impique = (Bitmap)CompilJeux.Properties.Resources.ResourceManager.GetObject("_" +
                i + "_pique_img");
                Bitmap imcoeur = (Bitmap)CompilJeux.Properties.Resources.ResourceManager.GetObject("_" +
                i + "_coeur_img");
                Bitmap imcarreau = (Bitmap)CompilJeux.Properties.Resources.ResourceManager.GetObject("_" +
                i + "_carreau_img");

                //ajout des cartes
                cartes.Add(new Carte(imtrefle, Carte.couleurs.TREFLE, i, lespuissances[i]));
                cartes.Add(new Carte(impique, Carte.couleurs.PIQUE, i, lespuissances[i]));
                cartes.Add(new Carte(imcoeur, Carte.couleurs.COEUR, i, lespuissances[i]));
                cartes.Add(new Carte(imcarreau, Carte.couleurs.CARREAU, i, lespuissances[i]));
            }
        }

        public void DebugAfficheCartes()
        {
            foreach (Carte c in cartes)
                c.DebugAffiche();
        }

        public void MelangerPaquet()
        {
            Random rng = new Random();
            int n = cartes.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Carte value = cartes[k];
                cartes[k] = cartes[n];
                cartes[n] = value;
            }  
        }

        public Carte TirerCarte()
        {
            if (cartes.Count > 0)
            {
                Carte carteTirée = new Carte(cartes[0]);
                cartes.RemoveAt(0);
                return carteTirée;
            }

            return null;
        }

        public void AjouterCarteFin(Carte nouvelleCarte)
        {
            if (!cartes.Contains(nouvelleCarte))
            {
                cartes.Add(nouvelleCarte);
            }
            
        }

        public int getNombreCartes()
        {
            return cartes.Count();
        }

        public Carte ChercherEtRetirerCarte(Carte carteCherchée)
        {
            if (cartes.Contains(carteCherchée))
            {
                Carte carteTrouvée;
                carteTrouvée = cartes.Find(new Predicate<Carte>(delegate(Carte c)
                { return c.couleur == carteCherchée.couleur && c.valeur == carteCherchée.valeur; }));
                cartes.Remove(carteTrouvée);
                return carteTrouvée;
            }
            
            return null;
        }


    }
}
