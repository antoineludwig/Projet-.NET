﻿namespace CompilJeux
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
            this.NbCartesJ2 = new System.Windows.Forms.Label();
            this.Gagnant = new System.Windows.Forms.Label();
            this.Simulation = new System.Windows.Forms.Button();
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
            this.JeuJoueur1.Size = new System.Drawing.Size(180, 175);
            this.JeuJoueur1.TabIndex = 0;
            this.JeuJoueur1.TabStop = false;
            this.JeuJoueur1.Click += new System.EventHandler(this.JeuJoueur1_Click);
            // 
            // JeuJoueur2
            // 
            this.JeuJoueur2.BackgroundImage = global::CompilJeux.Properties.Resources.dos_01_img;
            this.JeuJoueur2.Location = new System.Drawing.Point(303, 12);
            this.JeuJoueur2.Name = "JeuJoueur2";
            this.JeuJoueur2.Size = new System.Drawing.Size(180, 175);
            this.JeuJoueur2.TabIndex = 1;
            this.JeuJoueur2.TabStop = false;
            this.JeuJoueur2.Click += new System.EventHandler(this.JeuJoueur2_Click);
            // 
            // CarteJouee1
            // 
            this.CarteJouee1.Location = new System.Drawing.Point(208, 252);
            this.CarteJouee1.Name = "CarteJouee1";
            this.CarteJouee1.Size = new System.Drawing.Size(180, 175);
            this.CarteJouee1.TabIndex = 2;
            this.CarteJouee1.TabStop = false;
            // 
            // CarteJouee2
            // 
            this.CarteJouee2.Location = new System.Drawing.Point(394, 231);
            this.CarteJouee2.Name = "CarteJouee2";
            this.CarteJouee2.Size = new System.Drawing.Size(180, 175);
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
            // NbCartesJ2
            // 
            this.NbCartesJ2.AutoSize = true;
            this.NbCartesJ2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbCartesJ2.Location = new System.Drawing.Point(374, 127);
            this.NbCartesJ2.Name = "NbCartesJ2";
            this.NbCartesJ2.Size = new System.Drawing.Size(34, 24);
            this.NbCartesJ2.TabIndex = 5;
            this.NbCartesJ2.Text = "00";
            this.NbCartesJ2.Click += new System.EventHandler(this.NbCarteJ2_Click);
            // 
            // Gagnant
            // 
            this.Gagnant.AutoSize = true;
            this.Gagnant.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gagnant.ForeColor = System.Drawing.Color.Red;
            this.Gagnant.Location = new System.Drawing.Point(391, 435);
            this.Gagnant.Name = "Gagnant";
            this.Gagnant.Size = new System.Drawing.Size(0, 27);
            this.Gagnant.TabIndex = 7;
            this.Gagnant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Simulation
            // 
            this.Simulation.Location = new System.Drawing.Point(596, 518);
            this.Simulation.Name = "Simulation";
            this.Simulation.Size = new System.Drawing.Size(121, 47);
            this.Simulation.TabIndex = 8;
            this.Simulation.Text = "Simulation";
            this.Simulation.UseVisualStyleBackColor = true;
            this.Simulation.Click += new System.EventHandler(this.Simulation_Click);
            // 
            // Bataille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.Simulation);
            this.Controls.Add(this.Gagnant);
            this.Controls.Add(this.NbCartesJ2);
            this.Controls.Add(this.NbCartesJ1);
            this.Controls.Add(this.CarteJouee2);
            this.Controls.Add(this.CarteJouee1);
            this.Controls.Add(this.JeuJoueur2);
            this.Controls.Add(this.JeuJoueur1);
            this.Name = "Bataille";
            this.Text = "Bataille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bataille_FormClosed);
            this.Load += new System.EventHandler(this.Bataille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JeuJoueur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JeuJoueur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarteJouee1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarteJouee2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox JeuJoueur1;
        public System.Windows.Forms.PictureBox JeuJoueur2;
        public System.Windows.Forms.PictureBox CarteJouee1;
        public System.Windows.Forms.PictureBox CarteJouee2;
        public System.Windows.Forms.Label NbCartesJ1;
        public System.Windows.Forms.Label NbCartesJ2;
        public System.Windows.Forms.Label Gagnant;
        private System.Windows.Forms.Button Simulation;
    }
}