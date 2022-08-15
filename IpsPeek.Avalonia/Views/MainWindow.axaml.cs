using Avalonia.Controls;
using Avalonia.ReactiveUI;
using IpsPeek.UI.ViewModels;
using ReactiveUI;

namespace IpsPeek.Avalonia.Views
{
    public partial class MainWindow : ReactiveWindow<MainViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}