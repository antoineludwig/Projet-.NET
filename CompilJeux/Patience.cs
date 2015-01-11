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
    public partial class Patience : Form
    {
        public JeuPatience nouveauJeu; 

        public Patience()
        {
            InitializeComponent();
            nouveauJeu = new JeuPatience(this);
        }

        private void Pioche_Click(object sender, EventArgs e)
        {
            
            if (!nouveauJeu.finDuJeu)
            {
                nouveauJeu.TirerCarte(this);
            }
            else
            {
                if (nouveauJeu.Fin(this))
                {
                    MessageBox.Show("C'est la win");
                }
                else
                {
                    MessageBox.Show("C'est la loose");
                    this.Close();
                }
            }
        }

    }
}
