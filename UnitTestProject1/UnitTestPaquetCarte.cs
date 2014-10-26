using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompilJeux;
using System.Diagnostics;
using System.Drawing;


namespace UnitTestCompilJeux
{
    [TestClass]
    public class UnitTestPaquetCarte
    {
        [TestMethod]
        public void TestMelangerPaquet()
        {

            //initialisations
                Dictionary<int,int>listesPuissances = new Dictionary<int,int>();
                //puissances des cartes
                for (int i = 2; i <= 13; i++)
                {
                    listesPuissances.Add(i, i - 1);
                }
                //l'AS
                listesPuissances.Add(1, 13);

                PaquetCarte p = new PaquetCarte(listesPuissances);
                PaquetCarte p2 = new PaquetCarte(listesPuissances);

                p.MelangerPaquet();

            //tests
                Assert.AreEqual(p.getNombreCartes(), p2.getNombreCartes(),"Nombre de cartes différent");

                int nbcartediff=0;
                for (int i=1; i < p.getNombreCartes(); i++)
                {
                    if (p.cartes[i].valeur != p2.cartes[i].valeur)
                        nbcartediff++;
                }
                Assert.IsTrue(nbcartediff > 5,"Paquet non mélangé, moins de 5 cartes changées");

            
        }

        [TestMethod]
        public void TestTirerCarte()
        {

            //initialisations
            Dictionary<int, int> listesPuissances = new Dictionary<int, int>();
            //puissances des cartes
            for (int i = 2; i <= 13; i++)
            {
                listesPuissances.Add(i, i - 1);
            }
            //l'AS
            listesPuissances.Add(1, 13);

            PaquetCarte p = new PaquetCarte(listesPuissances);


            //tests
            int ancienneTaille = p.getNombreCartes();
            Carte c = p.TirerCarte();
            Assert.AreNotEqual(p.getNombreCartes(), ancienneTaille,"Taille du paquet identique");

            bool carteTrouvée=false;
            foreach (Carte laCarte in p.cartes)
                if (laCarte.valeur == c.valeur && laCarte.couleur == c.couleur)
                    carteTrouvée = true;
            Assert.IsFalse(carteTrouvée,"Carte toujours dans le paquet");

        }

        [TestMethod]
        public void TestAjouterCarteFin()
        {

            //initialisations
            Dictionary<int, int> listesPuissances = new Dictionary<int, int>();
            //puissances des cartes
            for (int i = 2; i <= 13; i++)
            {
                listesPuissances.Add(i, i - 1);
            }
            //l'AS
            listesPuissances.Add(1, 13);

            PaquetCarte p = new PaquetCarte(listesPuissances);


            //tests

            Carte c = new Carte();

            p.AjouterCarteFin(c);

            Assert.AreEqual(p.cartes[p.getNombreCartes()-1].valeur, c.valeur,"Carte pas à la fin");
            Assert.AreEqual(p.cartes[p.getNombreCartes()-1].couleur, c.couleur, "Carte pas à la fin");

        }

        [TestMethod]
        public void TestchercherEtRetirerCarte()
        {

            //initialisations
            Dictionary<int, int> listesPuissances = new Dictionary<int, int>();
            //puissances des cartes
            for (int i = 2; i <= 13; i++)
            {
                listesPuissances.Add(i, i - 1);
            }
            //l'AS
            listesPuissances.Add(1, 13);

            PaquetCarte p = new PaquetCarte(listesPuissances);


            //tests


        }
    }
}
