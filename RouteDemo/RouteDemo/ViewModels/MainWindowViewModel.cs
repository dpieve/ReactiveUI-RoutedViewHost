using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Diagnostics;
using System.Reactive.Disposables;

namespace RouteDemo.ViewModels;

public sealed class MainWindowViewModel : ActivatableViewModelBase
{
    public MainWindowViewModel()
    {
        this.WhenActivated(Activated);
    }

    [Reactive] public ViewModelBase CurrentViewModel { get; set; } = new MainViewModel();

    private void Activated(CompositeDisposable disposable)
    {
        Debug.WriteLine("Activated");
    }
}