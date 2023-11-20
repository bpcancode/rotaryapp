using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1;

public partial class MainPageViewModel : ObservableObject
{

    string halfNotice = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam dapibus lectus eget imperdiet sollicitudin. Sed hendrerit felis ut tempus dapibus. Pellentesque sagittis, felis non eleifend interdum, tortor neque mattis risus, non hendrerit diam leo eu mauris. Fusce ornare dignissim pretium. Vestibulum ";
    string fullNotice = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam dapibus lectus eget imperdiet sollicitudin. Sed hendrerit felis ut tempus dapibus. Pellentesque sagittis, felis non eleifend interdum, tortor neque mattis risus, non hendrerit diam leo eu mauris. Fusce ornare dignissim pretium. Vestibulum vitae mauris vitae eros pellentesque semper nec aliquam nisi. Phasellus id felis non nunc consequat iaculis nec non arcu. Aenean cursus, eros vitae finibus condimentum, massa diam dignissim tellus, vel posuere augue elit nec dui. Quisque felis velit, tristique eu accumsan at, euismod quis mi. Nulla euismod sit amet lorem et volutpat. Cras consequat viverra magna, ut ornare quam fringilla posuere. Pellentesque eleifend mi vitae vulputate sollicitudin. Aliquam scelerisque enim ut neque rutrum iaculis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nDonec eu malesuada dui, in luctus magna. Suspendisse mollis sem diam, et lobortis felis ullamcorper eu. Praesent a neque tellus. Fusce eu nulla sed diam pulvinar posuere sit amet consequat libero. Nullam bibendum mattis ligula pulvinar ullamcorper. Curabitur posuere a leo ut tempor. Duis sagittis congue mauris vel condimentum. Phasellus sit amet nisi non nibh faucibus ornare et sit amet tellus. Nunc venenatis non mi non vulputate. Phasellus lobortis orci vita";

    public MainPageViewModel()
    {
        data.Add("random 1");
        data.Add("random 1");
        data.Add("random 1");
        data.Add("random 1");
        data.Add("random 1");
        Notice = halfNotice;
    }

    [RelayCommand]
    void toggleExpender()
    {
        if(Expended) Notice = halfNotice;
        else Notice = fullNotice;

        Expended = !Expended;
    }

    [RelayCommand]
    async Task GotoEventPage()
    {
        await Shell.Current.GoToAsync(nameof(EventPage));
    }

    [RelayCommand]
    async Task GotoNewsPage()
    {
        await Shell.Current.GoToAsync(nameof(NewsPage));
    }

    [RelayCommand]
    async Task GotoEventDetail()
    {
        await Shell.Current.GoToAsync(nameof(EventDetailPage));
    }

    [ObservableProperty]
    string notice;

    [ObservableProperty]
    bool expended;

    [ObservableProperty]
    List<string> data = new();

    
}