using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OpenGameTools.Gui.ViewModel;
using OpenGameTools.Gui.ViewModel.ProjectExplorer;
using OpenGameTools.Gui.ViewModel.Quest;
using OpenGameTools.Gui.Wpf.ViewModel.ProjectExplorer;
using OpenGameTools.Gui.Wpf.ViewModel.DummyDocument;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.ViewModel {
    internal class MainWindowViewModel : ReactiveObject, IMainWindowViewModel {
        private readonly ILogger<MainWindowViewModel> _logger;
        private readonly IList<IToolViewModel> _visibleToolViewModels = new List<IToolViewModel> {
            new ProjectExplorerViewModel()
        };
        private readonly IReadOnlyList<IDocumentViewModel> _documentViewModels = new List<IDocumentViewModel>() {
            new QuestDocumentViewModel(),
            new DummyDocumentViewModel()
        };

        public IReadOnlyList<IDocumentViewModel> DocumentViewModels => _documentViewModels;
        public IList<IToolViewModel> VisibleToolViewModels => _visibleToolViewModels;

        public MainWindowViewModel(ILogger<MainWindowViewModel> logger) {
            _logger = logger;
        }
    }
}