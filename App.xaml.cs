using MauiApp1.View;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Routing.RegisterRoute(nameof(ClubDetailPage), typeof(ClubDetailPage));
            Routing.RegisterRoute(nameof(EventPage), typeof(EventPage));
            Routing.RegisterRoute(nameof(NewsPage), typeof(NewsPage));
            Routing.RegisterRoute(nameof(EventDetailPage), typeof(EventDetailPage));
        }
    }
}