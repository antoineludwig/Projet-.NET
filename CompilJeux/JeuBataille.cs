using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilJeux
{
    public class JeuBataille
    {
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
            
            jeu1 = new PaquetCarte(listesPuissances);
            jeu2 = new PaquetCarte(listesPuissances);

            règle = _règle;
        }

        public Carte TirerCarteJeu(PaquetCarte jeu)
        {
            //règle pour 1 joueur
            if (règle == 1)
            {
                return jeu1.TirerCarte();
            }

            //règle pour 2 joueurs
            if (règle==2)
            {

            }

            return null;
        }
    }
}
