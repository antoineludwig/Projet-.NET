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

        public static Dictionary<int,int>listesPuissances = new Dictionary<int,int>();

        public JeuBataille()
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


        }
    }
}
