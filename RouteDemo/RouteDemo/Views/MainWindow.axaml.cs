using Avalonia.ReactiveUI;
using RouteDemo.ViewModels;

namespace RouteDemo.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
}