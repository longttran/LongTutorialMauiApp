using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace LongTutorialMauiApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = [];
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string? entryText;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(EntryText))
            {
                return;
            }
            Items.Add(EntryText);
            EntryText = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            Items.Remove(s);
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?query={s}");
        }
    }
}
