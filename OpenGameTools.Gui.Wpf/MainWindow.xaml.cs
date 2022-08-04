using System;
using System.Collections.Generic;
using System.Linq;
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
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<IMainWindowViewModel>, IComponentConnector {
        public MainWindow(IMainWindowViewModel vm) {
            ViewModel = vm;
            InitializeComponent();
        }
    }
}