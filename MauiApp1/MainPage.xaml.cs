using System.Collections.ObjectModel;

namespace MauiApp1
{
    public class MainViewModel
    {
        public ObservableCollection<string> Items { get; } = new()
    {
        "Item 1", "Item 2", "Item 3"
    };
    }
    public partial class MainPage : ContentPage
    {
        readonly MainViewModel viewModel = new();
        int counter = 3;
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this.viewModel;
        }
        private void OnAddItemClicked(object? sender, EventArgs e)
        {
            this.viewModel.Items.Add($"Item {++counter}");
        }
    }

}
