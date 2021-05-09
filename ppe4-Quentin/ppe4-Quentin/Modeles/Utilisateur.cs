﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PPE4Damien.Modeles
{
    class Utilisateur
    {
        #region Attributs
        public static List<Utilisateur> CollClasse = new List<Utilisateur>();
        private int _id;
        private string _nom;
        private string _prenom;
        private string _mdp;
        private string _image;
        private List<Commande> _lesCommandes;

        //private Commande _laCommande;
        public Utilisateur(int id, string nom, string prenom, List<Commande> lesCommandes)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _lesCommandes = lesCommandes;
            this.SetListeCommandes();
            Utilisateur tc = Utilisateur.CollClasse.Find(x => (x.Id == id));
            if (tc == null) Utilisateur.CollClasse.Add(this);
        }

        #endregion
        #region Constructeurs
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Commande> LesCommandes { get => _lesCommandes; set => _lesCommandes = value; }

        #endregion
        #region Methodes
        private void SetListeCommandes()
        {
            foreach (Commande uneCommande in this.LesCommandes)
            {
                uneCommande.Lutilisateur = this;
            }
        }

        #endregion
    }
}
