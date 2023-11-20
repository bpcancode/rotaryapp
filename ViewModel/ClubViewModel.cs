using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel;

public partial class ClubViewModel : ObservableObject
{
    List<string> name = new();
    List<Datacollection> data = new();
    public ClubViewModel()
    {
        for(var i = 1; i<=25; i++)
        {
            name.Add("Name "+ i);
            data.Add(new Datacollection()
            {
                name = "Name" + i,
                isExpended = false
            }) ;
        }

        Names = name;
        Datas = data;
    }

    [RelayCommand]
    async Task GotoClubDetail()
    {
        await Shell.Current.GoToAsync(nameof(ClubDetailPage));
    }

    [RelayCommand]
    void ToggleExpansion(Datacollection d) 
    {
       d.IsExpended = !d.IsExpended;
    }

    [ObservableProperty]
    string searchText;

    [ObservableProperty]
    List<string> names = new();

    [ObservableProperty]
    List<Datacollection> datas;
}

public partial class Datacollection : ObservableObject
{

    [ObservableProperty]
    public string name;

    [ObservableProperty]
    public bool isExpended;
}
