using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using RouteDemo.ViewModels;

namespace RouteDemo.Views;

public partial class Page1View : ReactiveUserControl<Page1ViewModel>
{
    public Page1View()
    {
        InitializeComponent();
    }
}