using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenGameTools.Gui.ViewModel;
using OpenGameTools.Gui.Wpf.Properties;
using OpenGameTools.Gui.Wpf.ViewModel;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<IMainWindowViewModel>, IComponentConnector {
        private readonly IDockViewModel _layoutViewModel;

        public MainWindow(IMainWindowViewModel viewModel, IDockViewModel layoutViewModel) {
            Settings.Default.PropertyChanged += (sender, args) => Settings.Default.Save();

            ViewModel = viewModel;
            InitializeComponent();

            _layoutViewModel = layoutViewModel;

            this.WhenActivated(d => {
                d(HandleLayout());
                //d(this.WhenAnyValue(x => x.DockingManager).BindTo(_layoutViewModel, vm => vm.DockingManager));
                d(this.OneWayBind(ViewModel,
                    vm => vm.DocumentViewModels,
                    view => view.DockingManager.DocumentsSource)
                );
                d(this.OneWayBind(ViewModel,
                    vm => vm.VisibleToolViewModels,
                    view => view.DockingManager.AnchorablesSource)
                );
            });
        }

        private IDisposable HandleLayout() {
            _layoutViewModel.LoadLayoutCommand.Execute(null);

            return Disposable.Create(() => _layoutViewModel.SaveLayoutCommand.Execute(null));
        }
    }
}