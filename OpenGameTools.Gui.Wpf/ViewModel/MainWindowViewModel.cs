using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OpenGameTools.Gui.ViewModel;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.ViewModel {
    internal class MainWindowViewModel : ReactiveObject, IMainWindowViewModel {
        private readonly ILogger<MainWindowViewModel> _logger;

        public MainWindowViewModel(ILogger<MainWindowViewModel> logger) {
            _logger = logger;
        }
    }
}