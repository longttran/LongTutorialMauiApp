using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LongTutorialMauiApp.ViewModels
{
    [QueryProperty("Text", "query")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        public required string text;

        [RelayCommand]
        private static async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
