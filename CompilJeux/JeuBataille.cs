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
        //un joueur : règle=1, 2 joueur règle=2
        public int règle { get; set; }

        public static Dictionary<int,int>listesPuissances = new Dictionary<int,int>();

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

        public void TirerCarteJeu()
        {
            Carte carteTirée1;
            Carte carteTirée2;

            //règle pour 1 joueur
            if (règle == 1)
            {
                carteTirée1 = jeu1.TirerCarte();
                carteTirée2 = jeu2.TirerCarte();

                //test qui a gagné
                if (carteTirée1.puissance > carteTirée2.puissance)
                {
                    Joueur1Gagne(carteTirée1, carteTirée2);
                }

                if (carteTirée2.puissance > carteTirée1.puissance)
                {
                    Joueur2Gagne(carteTirée1, carteTirée2);
                }
                if (carteTirée1.puissance == carteTirée2.puissance)
                {
                    BatailleCarte(carteTirée1, carteTirée2);
                }
                    
            }

            //règle pour 2 joueurs
            if (règle==2)
            {

            }

        }

        public void BatailleCarte(Carte c1, Carte c2)
        {

        }

        public void Joueur1Gagne(Carte c1, Carte c2)
        {
            vueBataille.Gagnant.Text = "Joueur 1 gagne ce tour!";
            jeu2.AjouterCarteFin(c1);
            jeu2.AjouterCarteFin(c2);
        }

        public void Joueur2Gagne(Carte c1, Carte c2)
        {
            vueBataille.Gagnant.Text = "Joueur 2 gagne ce tour!";
            jeu1.AjouterCarteFin(c1);
            jeu1.AjouterCarteFin(c2);
        }

        public void TourSuivant()
        {
            if (jeu1.getNombreCartes() == 0)
                FinDuJeu("Joueur 1 gagne la partie !");
            if (jeu2.getNombreCartes() == 0)
                FinDuJeu("Joueur 2 gagne la partie !");

            vueBataille.JeuJoueur1.BackgroundImage.Dispose();
            vueBataille.JeuJoueur2.BackgroundImage.Dispose();
            vueBataille.NbCartesJ1.Text = jeu1.getNombreCartes().ToString();
            vueBataille.NbCartesJ2.Text = jeu2.getNombreCartes().ToString();

        }

        public void FinDuJeu(String texteVictoire)
        {
            MessageBox.Show(texteVictoire, "Fin du jeu");
            vueBataille.Close();
        }

    }
}
