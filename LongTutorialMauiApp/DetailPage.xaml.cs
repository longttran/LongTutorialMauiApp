using LongTutorialMauiApp.ViewModels;

namespace LongTutorialMauiApp
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage(DetailViewModel vm)
		{
			InitializeComponent();
			BindingContext = vm;
		}
	}
}