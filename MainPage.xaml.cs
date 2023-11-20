using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

    public ObservableCollection<string> Items = new();
    public MainPage()
    {
        Items.Add("2080 Batch Welcome Program");
        Items.Add("2080 Batch Welcome Program");
        Items.Add("2080 Batch Welcome Program");
        Items.Add("2080 Batch Welcome Program");
        Items.Add("2080 Batch Welcome Program");
        BindingContext = this;
        InitializeComponent();
    }
}