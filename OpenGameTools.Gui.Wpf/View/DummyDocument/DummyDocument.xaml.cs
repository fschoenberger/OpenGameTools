using System.Windows.Markup;
using OpenGameTools.Gui.Wpf.ViewModel.DummyDocument;
using OpenGameTools.Gui.Wpf.ViewModel.ProjectExplorer;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.View.DummyDocument {
    /// <summary>
    /// Interaction logic for ProjectExplorerViewModel.xaml
    /// </summary>
    public partial class DummyDocument : ReactiveUserControl<DummyDocumentViewModel>, IComponentConnector {
        public DummyDocument() {
            InitializeComponent();
        }
    }
}