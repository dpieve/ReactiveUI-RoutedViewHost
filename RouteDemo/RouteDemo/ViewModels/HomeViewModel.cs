using ReactiveUI;
using System;
using System.Diagnostics;
using System.Reactive;

namespace RouteDemo.ViewModels;

public sealed class HomeViewModel : PageViewModelBase
{
    public HomeViewModel(IScreen hostScreen) : base(hostScreen, "Home")
    {
        Page1 = ReactiveCommand.CreateFromObservable(GoToPage1);
        Page2 = ReactiveCommand.CreateFromObservable(GoToPage2);
    }

    public ReactiveCommand<Unit, IRoutableViewModel> Page1 { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> Page2 { get; }

    private IObservable<IRoutableViewModel> GoToPage1()
    {
        Debug.Write("GoToPage1!");
        return HostScreen.Router.Navigate.Execute(new Page1ViewModel(HostScreen));
    }

    private IObservable<IRoutableViewModel> GoToPage2()
    {
        Debug.Write("GoToPage2!");
        return HostScreen.Router.Navigate.Execute(new Page2ViewModel(HostScreen));
    }
}