using ReactiveUI;

namespace RouteDemo.ViewModels;

public class PageViewModelBase(IScreen hostScreen, string urlPathSegment)
        : ViewModelBase, IRoutableViewModel
{
    public IScreen HostScreen { get; } = hostScreen;
    public string? UrlPathSegment { get; } = urlPathSegment;
}