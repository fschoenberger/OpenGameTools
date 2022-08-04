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
using OpenGameTools.Gui.ViewModel.ProjectExplorer;
using OpenGameTools.Gui.Wpf.ViewModel.ProjectExplorer;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.View.ProjectExplorer {
    /// <summary>
    /// Interaction logic for ProjectExplorerViewModel.xaml
    /// </summary>
    public partial class ProjectExplorer : ReactiveUserControl<ProjectExplorerViewModel>, IComponentConnector {
        public ProjectExplorer() {
            InitializeComponent();
        }
    }
}