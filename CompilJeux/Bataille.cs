using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilJeux
{
    public partial class Bataille : Form
    {
        public JeuBataille nouveauJeu = new JeuBataille(1);

        public Bataille()
        {
            InitializeComponent();
        }

        private void Bataille_Load(object sender, EventArgs e)
        {
            
        }

        private void NbCartesJ1_Click(object sender, EventArgs e)
        {
            JeuJoueur1_Click(sender,e);
        }

        private void JeuJoueur1_Click(object sender, EventArgs e)
        {
            nouveauJeu.jeu1.TirerCarte(); 
        }

        private void NbCarteJ2_Click(object sender, EventArgs e)
        {
            JeuJoueur2_Click(sender, e);

        }

        private void JeuJoueur2_Click(object sender, EventArgs e)
        {
            Carte carteTirée = nouveauJeu.jeu2.TirerCarte();
            CarteJouee2.BackgroundImage = carteTirée.imagecarte;
        }
    }
}
