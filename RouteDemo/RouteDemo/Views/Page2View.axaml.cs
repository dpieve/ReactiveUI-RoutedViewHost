using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using RouteDemo.ViewModels;

namespace RouteDemo.Views;

public partial class Page2View : ReactiveUserControl<Page2ViewModel>
{
    public Page2View()
    {
        InitializeComponent();
    }
}