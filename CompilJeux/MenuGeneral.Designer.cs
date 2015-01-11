namespace CompilJeux
{
    partial class MenuGeneral
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.jeuxDeCartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batailleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuxDeCartesToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(884, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // jeuxDeCartesToolStripMenuItem
            // 
            this.jeuxDeCartesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batailleToolStripMenuItem,
            this.patienceToolStripMenuItem});
            this.jeuxDeCartesToolStripMenuItem.Name = "jeuxDeCartesToolStripMenuItem";
            this.jeuxDeCartesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.jeuxDeCartesToolStripMenuItem.Text = "Jeux de cartes";
            // 
            // batailleToolStripMenuItem
            // 
            this.batailleToolStripMenuItem.Name = "batailleToolStripMenuItem";
            this.batailleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.batailleToolStripMenuItem.Text = "Bataille";
            this.batailleToolStripMenuItem.Click += new System.EventHandler(this.batailleToolStripMenuItem_Click);
            // 
            // patienceToolStripMenuItem
            // 
            this.patienceToolStripMenuItem.Name = "patienceToolStripMenuItem";
            this.patienceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patienceToolStripMenuItem.Text = "Patience";
            this.patienceToolStripMenuItem.Click += new System.EventHandler(this.patienceToolStripMenuItem_Click);
            // 
            // MenuGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MenuGeneral";
            this.Text = "Compilations de jeux";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem jeuxDeCartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batailleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patienceToolStripMenuItem;
    }
}

