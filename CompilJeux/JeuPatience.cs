using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompilJeux
{
    public class JeuPatience
    {
        public Dictionary<int, int> listesPuissances = new Dictionary<int, int>();
        public PaquetCarte jeu;
        public int[,] plateau = new int[4,8];
        public int nbAs=0;
        public bool finDuJeu=false;

        public JeuPatience(Patience patience)
        {
            //puissances des cartes
            for (int i = 7; i <= 13; i++)
            {
                listesPuissances.Add(i, i);
            }

            jeu = new PaquetCarte(listesPuissances,7);
            jeu.ajoutAsMAx();
            jeu.MelangerPaquet();

            //mise à 0 du plateau

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    plateau[i, j] = 0;
                }
            }

            //placement des cartes sur le formulaire
            for (int i = 7; i <= 14; i++)
            {
                PictureBox cp = (PictureBox)patience.Controls.Find("C" + i + "P", false)[0];
                cp.BackgroundImage = CompilJeux.Properties.Resources.dos_01_img;
                PictureBox co = (PictureBox)patience.Controls.Find("C" + i + "CO", false)[0];
                co.BackgroundImage = CompilJeux.Properties.Resources.dos_01_img;
                PictureBox ct = (PictureBox)patience.Controls.Find("C" + i + "T", false)[0];
                ct.BackgroundImage = CompilJeux.Properties.Resources.dos_01_img;
                PictureBox ca = (PictureBox)patience.Controls.Find("C" + i + "CA", false)[0];
                ca.BackgroundImage = CompilJeux.Properties.Resources.dos_01_img;
            }
        }

        //pioche une carte
        public void TirerCarte(Patience patience)
        {
            Carte carteTirée;
            carteTirée=jeu.TirerCarte();

            if (carteTirée.puissance == 14)
            {
                nbAs++;
            }
            switch (carteTirée.couleur)
            {
                case Carte.couleurs.PIQUE:
                    PictureBox cp = (PictureBox)patience.Controls.Find("C" + carteTirée.puissance + "P",false)[0];
                    cp.BackgroundImage = carteTirée.imagecarte;
                    plateau[0,carteTirée.puissance-7]=carteTirée.puissance;
                    break;
                case Carte.couleurs.COEUR:
                    PictureBox cco = (PictureBox)patience.Controls.Find("C" + carteTirée.puissance + "CO", false)[0];
                    cco.BackgroundImage = carteTirée.imagecarte;
                    plateau[1,carteTirée.puissance-7]=carteTirée.puissance;
                    break;
                case Carte.couleurs.TREFLE:
                    PictureBox ct = (PictureBox)patience.Controls.Find("C" + carteTirée.puissance + "T", false)[0];
                    ct.BackgroundImage = carteTirée.imagecarte;
                    plateau[2,carteTirée.puissance-7]=carteTirée.puissance;
                    break;
                case Carte.couleurs.CARREAU:
                    PictureBox car = (PictureBox)patience.Controls.Find("C" + carteTirée.puissance + "CA", false)[0];
                    car.BackgroundImage = carteTirée.imagecarte;
                    plateau[3,carteTirée.puissance-7]=carteTirée.puissance;
                    break;
            }

            if (nbAs == 4)
            {
                finDuJeu = true;
            }
            

        }

        //renvoie true si le jeu est gagner, false sinon
        public bool Fin(Patience patience)
        {
            int i=0,j=0;
            //vérification que les carte sont bien triées
            while (i<4 && j<8)
            {
                if(plateau[i,j]==0)
                {
                    //tirer une carte
                    Carte carteTirée;
                    carteTirée = jeu.TirerCarte();

                    //si mauvaise ligne
                    //pique
                    if(i==0)
                    {
                        PictureBox cp = (PictureBox)patience.Controls.Find("C" + (j + 7) + "P", false)[0];
                        cp.BackgroundImage = carteTirée.imagecarte;
                        plateau[i, j] = carteTirée.puissance;
                        if(carteTirée.couleur!=Carte.couleurs.PIQUE) return false;
                    }
                    //coeur
                    if(i==1)
                    {
                        PictureBox cco = (PictureBox)patience.Controls.Find("C" + (j + 7) + "CO", false)[0];
                        cco.BackgroundImage = carteTirée.imagecarte;
                        plateau[i, j] = carteTirée.puissance;
                        if (carteTirée.couleur != Carte.couleurs.COEUR) return false;
                    }
                    //trefle
                    if(i==2)
                    {
                        PictureBox ct = (PictureBox)patience.Controls.Find("C" + (j + 7) + "T", false)[0];
                        ct.BackgroundImage = carteTirée.imagecarte;
                        plateau[i, j] = carteTirée.puissance;
                        if (carteTirée.couleur != Carte.couleurs.TREFLE) return false;
                    }
                    //carreau
                    if(i==3)
                    {
                        PictureBox car = (PictureBox)patience.Controls.Find("C" + (j + 7) + "CA", false)[0];
                        car.BackgroundImage = carteTirée.imagecarte;
                        plateau[i, j] = carteTirée.puissance;
                        if (carteTirée.couleur != Carte.couleurs.CARREAU) return false;
                    }
                    //si mauvaise colonne
                    if (carteTirée.puissance != j + 7) return false;
                    
                }
                //déplacement dans le tableau
                if (j == 7)
                {
                    j = 0;
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return true;
        }

    }
}
