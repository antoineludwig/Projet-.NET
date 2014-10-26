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
    public partial class MenuGeneral : Form
    {
        public MenuGeneral()
        {
            InitializeComponent();
        }

        private void batailleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bataille uneBataille = new Bataille();
            uneBataille.Show();
        }

    }
}
