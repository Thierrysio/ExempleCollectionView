using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExempleCollectionView.Modeles
{
    public class Produit
    {
        #region Attributs

        public static ObservableCollection<Produit> CollClasse = new ObservableCollection<Produit>();

        private int _id;
        private string _nom;
        private string _photo;

        #endregion

        #region Constructeurs



        public Produit(int id, string nom, string photo)
        {

            Id = id;
            Nom = nom;
            Produit.CollClasse.Add(this);
            _photo = photo;
        }

        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Photo { get => _photo; set => _photo = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
