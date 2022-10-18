using ExempleCollectionView.Modeles;
using ExempleCollectionView.VuesModeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCollectionView.VueModeles
{
    internal class ExempleCollectionVueModele : BaseVueModele
    {
        #region attributs
        private ObservableCollection<Produit> _maListeProduits;
        #endregion

        #region Constructeurs
        public  ExempleCollectionVueModele()
        { 
        new Produit(1,"Polaroid PROG40C","https://media.ldlc.com/ld/products/00/01/23/78/LD0001237887_2.jpg");
        new Produit(2, "Wiko U Feel Prime", "https://img.generation-nt.com/wiwiko-u-feel-prime_05DC057101642169.jpg");

            MaListeProduits = Produit.CollClasse;
    }
        #endregion

        #region Getters/Setters
        public ObservableCollection<Produit> MaListeProduits
        {
            get { return _maListeProduits; }
            set { SetProperty(ref _maListeProduits, value); }
        }
        #endregion

        #region Methodes
        #endregion
    }
}
