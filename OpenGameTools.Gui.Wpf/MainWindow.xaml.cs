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
using MahApps.Metro.Controls;
using OpenGameTools.Gui.ViewModel;
using OpenGameTools.Gui.Wpf.Properties;
using OpenGameTools.Gui.Wpf.ViewModel;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow /*ReactiveWindow<IMainWindowViewModel>*/, IViewFor<IMainWindowViewModel>, IComponentConnector
    {
        private readonly IDockViewModel _layoutViewModel;

        public MainWindow(IMainWindowViewModel viewModel, IDockViewModel layoutViewModel)
        {
            Settings.Default.PropertyChanged += (sender, args) => Settings.Default.Save();

            ViewModel = viewModel;
            InitializeComponent();

            _layoutViewModel = layoutViewModel;

            this.WhenActivated(d =>
            {
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

        /// <summary>
        /// The view model dependency property.
        /// </summary>
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(
                                        "ViewModel",
                                        typeof(IMainWindowViewModel),
                                        typeof(ReactiveWindow<IMainWindowViewModel>),
                                        new PropertyMetadata(null));

        public IMainWindowViewModel? BindingRoot => ViewModel;

        public IMainWindowViewModel? ViewModel {
            get => (IMainWindowViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        /// <inheritdoc/>
        object? IViewFor.ViewModel {
            get => ViewModel;
            set => ViewModel = (IMainWindowViewModel?)value;
        }

        private IDisposable HandleLayout()
        {
            _layoutViewModel.LoadLayoutCommand.Execute(null);

            return Disposable.Create(() => _layoutViewModel.SaveLayoutCommand.Execute(null));
        }
    }
}