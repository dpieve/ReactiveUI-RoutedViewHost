using Avalonia.ReactiveUI;
using RouteDemo.ViewModels;

namespace RouteDemo.Views;

public partial class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        InitializeComponent();
    }
}