using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using RouteDemo.ViewModels;

namespace RouteDemo.Views;

public partial class HomeView : ReactiveUserControl<HomeViewModel>
{
    public HomeView()
    {
        InitializeComponent();
    }
}