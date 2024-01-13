using ReactiveUI;

namespace RouteDemo.ViewModels;

public sealed class Page1ViewModel(IScreen hostScreen) : PageViewModelBase(hostScreen, "Page1");