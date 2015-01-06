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

        public PaquetCarte(PaquetCarte pc)
        {
            cartes = new List<Carte> (pc.cartes);
        }

        public PaquetCarte(List<Carte> liste)
        {
            cartes = new List<Carte>(liste);
        }

        /**
         * Affichage des cartes
         * */
        public void DebugAfficheCartes()
        {
            foreach (Carte c in cartes)
                c.DebugAffiche();
        }

        /**
         * Mélange des cartes
         * */
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

        /**
         * Tirer une carte
         * */
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

        /**
         * Ajouter une carte à la fin
         * */
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

        /**
         * Retirer une carte précise du paquet
         * */
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

        /**
         * Coupe le paquet de carte pour le séparer dans 2 jeux de cartes distincts
         * */
        public List<PaquetCarte> Couper()
        {
            List<PaquetCarte> lesjeux = new List<PaquetCarte>();
            
            List<Carte> cartes1 = new List<Carte>(cartes.GetRange(0, 26));
            List<Carte> cartes2 = new List<Carte>(cartes.GetRange(26, 26));

            PaquetCarte jeu1 = new PaquetCarte(cartes1);
            PaquetCarte jeu2 = new PaquetCarte(cartes2);
            lesjeux.Add(jeu1);
            lesjeux.Add(jeu2);

            return (lesjeux);
        }
    }
}
