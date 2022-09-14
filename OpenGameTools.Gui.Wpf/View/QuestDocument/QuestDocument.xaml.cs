using System.Windows.Markup;
using OpenGameTools.Gui.ViewModel.QuestDocument;
using OpenGameTools.Gui.Wpf.ViewModel.DummyDocument;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.View.QuestDocument {
    /// <summary>
    /// Interaction logic for ProjectExplorerViewModel.xaml
    /// </summary>
    public partial class QuestDocument: ReactiveUserControl<QuestDocumentViewModel>, IComponentConnector {
        public QuestDocument() {
            InitializeComponent();
        }
    }
}