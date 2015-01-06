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
        public JeuBataille nouveauJeu; 

        public Bataille()
        {
            InitializeComponent();
            nouveauJeu = new JeuBataille(1);
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
            nouveauJeu.TirerCarteJeu(this); 
        }

        private void NbCarteJ2_Click(object sender, EventArgs e)
        {
            JeuJoueur2_Click(sender, e);

        }

        private void JeuJoueur2_Click(object sender, EventArgs e)
        {
            /*Carte carteTirée = nouveauJeu.jeu2.TirerCarte();
            CarteJouee2.BackgroundImage = carteTirée.imagecarte;*/
        }

        private void Simulation_Click(object sender, EventArgs e)
        {
            int i=0;
            while (i < 99 && !this.IsDisposed)
            {
                JeuJoueur1_Click(sender, e);
                i++;
            }
        }

        private void Bataille_FormClosed(object sender, FormClosedEventArgs e)
        {
            nouveauJeu = null;
        }


    }
}
