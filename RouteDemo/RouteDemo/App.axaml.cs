using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using RouteDemo.ViewModels;
using RouteDemo.Views;
using Splat;

namespace RouteDemo;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        Register();

        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel()
                };
                break;

            case ISingleViewApplicationLifetime singleViewPlatform:
                singleViewPlatform.MainView = new MainView
                {
                    DataContext = new MainViewModel()
                };
                break;
        }

        base.OnFrameworkInitializationCompleted();
    }

    public static void Register()
    {
        Locator.CurrentMutable.Register(() => new HomeView(), typeof(IViewFor<HomeViewModel>));
        Locator.CurrentMutable.Register(() => new MainView(), typeof(IViewFor<MainViewModel>));
        Locator.CurrentMutable.Register(() => new Page1View(), typeof(IViewFor<Page1ViewModel>));
        Locator.CurrentMutable.Register(() => new Page2View(), typeof(IViewFor<Page2ViewModel>));
    }
}