namespace CompilJeux
{
    partial class Bataille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.JeuJoueur1 = new System.Windows.Forms.PictureBox();
            this.JeuJoueur2 = new System.Windows.Forms.PictureBox();
            this.CarteJouee1 = new System.Windows.Forms.PictureBox();
            this.CarteJouee2 = new System.Windows.Forms.PictureBox();
            this.NbCartesJ1 = new System.Windows.Forms.Label();
            this.NbCarteJ2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JeuJoueur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JeuJoueur2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarteJouee1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarteJouee2)).BeginInit();
            this.SuspendLayout();
            // 
            // JeuJoueur1
            // 
            this.JeuJoueur1.BackgroundImage = global::CompilJeux.Properties.Resources.dos_01_img;
            this.JeuJoueur1.Location = new System.Drawing.Point(303, 470);
            this.JeuJoueur1.Name = "JeuJoueur1";
            this.JeuJoueur1.Size = new System.Drawing.Size(180, 180);
            this.JeuJoueur1.TabIndex = 0;
            this.JeuJoueur1.TabStop = false;
            this.JeuJoueur1.Click += new System.EventHandler(this.JeuJoueur1_Click);
            // 
            // JeuJoueur2
            // 
            this.JeuJoueur2.BackgroundImage = global::CompilJeux.Properties.Resources.dos_01_img;
            this.JeuJoueur2.Location = new System.Drawing.Point(303, 12);
            this.JeuJoueur2.Name = "JeuJoueur2";
            this.JeuJoueur2.Size = new System.Drawing.Size(180, 180);
            this.JeuJoueur2.TabIndex = 1;
            this.JeuJoueur2.TabStop = false;
            this.JeuJoueur2.Click += new System.EventHandler(this.JeuJoueur2_Click);
            // 
            // CarteJouee1
            // 
            this.CarteJouee1.Location = new System.Drawing.Point(208, 241);
            this.CarteJouee1.Name = "CarteJouee1";
            this.CarteJouee1.Size = new System.Drawing.Size(180, 180);
            this.CarteJouee1.TabIndex = 2;
            this.CarteJouee1.TabStop = false;
            // 
            // CarteJouee2
            // 
            this.CarteJouee2.Location = new System.Drawing.Point(394, 241);
            this.CarteJouee2.Name = "CarteJouee2";
            this.CarteJouee2.Size = new System.Drawing.Size(180, 180);
            this.CarteJouee2.TabIndex = 3;
            this.CarteJouee2.TabStop = false;
            // 
            // NbCartesJ1
            // 
            this.NbCartesJ1.AutoSize = true;
            this.NbCartesJ1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbCartesJ1.Location = new System.Drawing.Point(374, 585);
            this.NbCartesJ1.Name = "NbCartesJ1";
            this.NbCartesJ1.Size = new System.Drawing.Size(34, 24);
            this.NbCartesJ1.TabIndex = 4;
            this.NbCartesJ1.Text = "00";
            this.NbCartesJ1.Click += new System.EventHandler(this.NbCartesJ1_Click);
            // 
            // NbCarteJ2
            // 
            this.NbCarteJ2.AutoSize = true;
            this.NbCarteJ2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbCarteJ2.Location = new System.Drawing.Point(374, 127);
            this.NbCarteJ2.Name = "NbCarteJ2";
            this.NbCarteJ2.Size = new System.Drawing.Size(34, 24);
            this.NbCarteJ2.TabIndex = 5;
            this.NbCarteJ2.Text = "00";
            this.NbCarteJ2.Click += new System.EventHandler(this.NbCarteJ2_Click);
            // 
            // Bataille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.NbCarteJ2);
            this.Controls.Add(this.NbCartesJ1);
            this.Controls.Add(this.CarteJouee2);
            this.Controls.Add(this.CarteJouee1);
            this.Controls.Add(this.JeuJoueur2);
            this.Controls.Add(this.JeuJoueur1);
            this.Name = "Bataille";
            this.Text = "Bataille";
            this.Load += new System.EventHandler(this.Bataille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JeuJoueur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JeuJoueur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarteJouee1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarteJouee2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JeuJoueur1;
        private System.Windows.Forms.PictureBox JeuJoueur2;
        private System.Windows.Forms.PictureBox CarteJouee1;
        private System.Windows.Forms.PictureBox CarteJouee2;
        private System.Windows.Forms.Label NbCartesJ1;
        private System.Windows.Forms.Label NbCarteJ2;
    }
}