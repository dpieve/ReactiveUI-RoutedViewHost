using ReactiveUI;
using System;
using System.Reactive;
using System.Reactive.Linq;

namespace RouteDemo.ViewModels;

public class MainViewModel : ViewModelBase, IScreen
{
    public MainViewModel()
    {
        Router.Navigate.Execute(new HomeViewModel(this));

        var canGoBack = this
            .WhenAnyValue(x => x.Router.NavigationStack.Count)
            .Select(count => count > 1);

        Back = ReactiveCommand.CreateFromObservable(GoBack, canGoBack);
    }

    public RoutingState Router { get; } = new();

    public ReactiveCommand<Unit, IRoutableViewModel> Back { get; }

    private IObservable<IRoutableViewModel> GoBack()
    {
        return Router.NavigateBack.Execute(Unit.Default)!;
    }
}