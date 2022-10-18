using ExempleCollectionView.Modeles;
using ExempleCollectionView.VueModeles;

namespace ExempleCollectionView.Vues;

public partial class ExempleCollectionVue : ContentPage
{
	ExempleCollectionVueModele vueModele;
    public ExempleCollectionVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new ExempleCollectionVueModele();
	}

	private void CollViewSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
        Produit current = (Produit)e.CurrentSelection.FirstOrDefault();


    }
}