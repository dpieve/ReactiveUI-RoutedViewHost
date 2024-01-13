using ReactiveUI;

namespace RouteDemo.ViewModels;

public class ActivatableViewModelBase : ViewModelBase, IActivatableViewModel
{
    public ViewModelActivator Activator { get; } = new();
}