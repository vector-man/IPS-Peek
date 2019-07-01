using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace IpsPeek.ViewModels
{
    public interface IWindow
    {
        bool CloseRequested { get; set; }

        ReactiveCommand<Unit, Unit> RequestClose { get; set; }
    }
}
