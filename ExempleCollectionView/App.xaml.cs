using ExempleCollectionView.Vues;

namespace ExempleCollectionView;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ExempleCollectionVue();
	}
}
