using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilJeux
{
    public class JeuBataille
    {
        public PaquetCarte jeu;
        public PaquetCarte jeu1;
        public PaquetCarte jeu2;
        public Carte carteCachée1 = null;
        public Carte carteCachée2 = null;
        public Boolean etatBataille = false;

        //un joueur : règle=1, 2 joueur règle=2
        public int règle { get; set; }

        public Dictionary<int,int>listesPuissances = new Dictionary<int,int>();

        public JeuBataille(int _règle)
        {
            //puissances des cartes
            for (int i = 2; i <= 13; i++)
            {
                listesPuissances.Add(i, i - 1);
            }
            //l'AS
            listesPuissances.Add(1, 13);


            jeu = new PaquetCarte(listesPuissances);
            jeu.MelangerPaquet();

            List<PaquetCarte> JeuCoupé = new List<PaquetCarte>();
            JeuCoupé = jeu.Couper();
            
            jeu1 = new PaquetCarte(JeuCoupé[0]);
            jeu2 = new PaquetCarte(JeuCoupé[1]);

            règle = _règle;
        }

        public void TirerCarteJeu(Bataille maBataille)
        {
            Carte carteTirée1;
            Carte carteTirée2;

            //mise à jour affichage nb de cartes des joueurs
            maBataille.NbCartesJ1.Text = jeu1.getNombreCartes().ToString();
            maBataille.NbCartesJ2.Text = jeu2.getNombreCartes().ToString();

            //règle pour 1 joueur
            if (règle == 1)
            {
                //si on est en bataille
                if (etatBataille)
                {
                    //les deux joueurs tire une carte et la cache
                    carteCachée1 = jeu1.TirerCarte();
                    maBataille.CarteJouee1.BackgroundImage = CompilJeux.Properties.Resources.dos_01_img;
                    carteCachée2 = jeu2.TirerCarte();
                    maBataille.CarteJouee2.BackgroundImage = CompilJeux.Properties.Resources.dos_01_img;
                    TourSuivant(maBataille);
                    etatBataille = false;
                }
                else
                {
                    //chaque joueur pioche une carte
                    carteTirée1 = jeu1.TirerCarte();
                    carteTirée2 = jeu2.TirerCarte();
                    //place les cartes sur la table
                    maBataille.CarteJouee1.BackgroundImage = carteTirée1.imagecarte;
                    maBataille.CarteJouee2.BackgroundImage = carteTirée2.imagecarte;

                    //test qui a gagné
                    if (carteTirée1.puissance > carteTirée2.puissance)
                    {
                        Joueur1Gagne(carteTirée1, carteTirée2,maBataille);
                        //maBataille.JeuJoueur1.BackgroundImage = carteTirée1.imagecarte;       
                    }

                    if (carteTirée2.puissance > carteTirée1.puissance)
                    {
                        Joueur2Gagne(carteTirée1, carteTirée2,maBataille);
                        //maBataille.JeuJoueur1.BackgroundImage = carteTirée1.imagecarte;  
                    }
                    if (carteTirée1.puissance == carteTirée2.puissance)
                    {
                        BatailleCarte(maBataille);
                    }
                    TourSuivant(maBataille);
                }    
                    
            }

            //règle pour 2 joueurs
            if (règle==2)
            {

            }

        }

        /**
         * Gestion d'un cas de bataille
         * */
        public void BatailleCarte(Bataille b)
        {
            b.Gagnant.Text = "Bataille!";
            //vérifie si il reste des cartes aux joueurs
            TourSuivant(b);
            etatBataille = true;
        }

        public void Joueur1Gagne(Carte c1, Carte c2, Bataille b)
        {
            b.Gagnant.Text = "Joueur 1 gagne ce tour!";
            jeu1.AjouterCarteFin(c1);
            jeu1.AjouterCarteFin(c2);
            if (carteCachée1 != null && carteCachée2 != null)
            {
                jeu1.AjouterCarteFin(carteCachée1);
                jeu1.AjouterCarteFin(carteCachée2);
                carteCachée1 = null;
                carteCachée2 = null;
            }
            jeu1.MelangerPaquet();
        }

        public void Joueur2Gagne(Carte c1, Carte c2, Bataille b)
        {
            b.Gagnant.Text = "Joueur 2 gagne ce tour!";
            jeu2.AjouterCarteFin(c1);
            jeu2.AjouterCarteFin(c2);
            if (carteCachée1 != null && carteCachée2 != null)
            {
                jeu2.AjouterCarteFin(carteCachée1);
                jeu2.AjouterCarteFin(carteCachée2);
                carteCachée1 = null;
                carteCachée2 = null;
            }
            jeu2.MelangerPaquet();
        }

        public void TourSuivant(Bataille b)
        {
            if (jeu1.getNombreCartes() == 0)
                FinDuJeu("Joueur 2 gagne la partie !",b);
            if (jeu2.getNombreCartes() == 0)
                FinDuJeu("Joueur 1 gagne la partie !",b);
        }

        public void FinDuJeu(String texteVictoire,Bataille b)
        {
            MessageBox.Show(texteVictoire, "Fin du jeu");
            b.Close();
        }

    }
}
