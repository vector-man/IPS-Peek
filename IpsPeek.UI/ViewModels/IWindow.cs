using System.Reactive;
using ReactiveUI;

namespace IpsPeek.UI.ViewModels
{
    public interface IWindow
    {
        bool CloseRequested { get; set; }

        ReactiveCommand<Unit, Unit> RequestClose { get; set; }
    }
}