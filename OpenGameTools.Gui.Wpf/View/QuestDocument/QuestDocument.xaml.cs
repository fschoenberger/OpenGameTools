using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Windows.Markup;
using OpenGameTools.Gui.ViewModel.Quest;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.View.QuestDocument {
    /// <summary>
    /// Interaction logic for ProjectExplorerViewModel.xaml
    /// </summary>
    public partial class QuestDocument: ReactiveUserControl<QuestDocumentViewModel>, IComponentConnector {
        public QuestDocument() {
            InitializeComponent();

            this.WhenActivated(d => {
                this.OneWayBind(ViewModel, vm => vm.States, view => view.Editor.ItemsSource).DisposeWith(d);
                this.OneWayBind(ViewModel, vm => vm.Transitions, view => view.Editor.Connections).DisposeWith(d);

                this.OneWayBind(ViewModel, vm => vm.CreateTransition, view => view.Editor.ConnectionCompletedCommand)
                    .DisposeWith(d);
            });
        }
    }
}