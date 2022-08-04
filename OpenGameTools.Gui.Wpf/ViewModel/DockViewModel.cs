using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Extensions.Logging;
using OpenGameTools.Gui.ViewModel;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.ViewModel {
    class DockViewModel : ReactiveObject, IDockViewModel {
        public ICommand LoadLayoutCommand => _loadLayoutCommand;
        public ICommand SaveLayoutCommand => _saveLayoutCommand;

        private readonly ReactiveCommand<Unit, Unit> _loadLayoutCommand;
        private readonly ReactiveCommand<Unit, Unit> _saveLayoutCommand;

        public DockViewModel(ILogger<IDockViewModel> logger) {
            _loadLayoutCommand = ReactiveCommand.Create(() => {
                // TODO
                logger.LogInformation("Loading Docking Layout...");
            }, Observable.Return(true), RxApp.TaskpoolScheduler);

            _saveLayoutCommand = ReactiveCommand.Create(() => {
                // TODO
                logger.LogInformation("Saving Docking Layout");
            }, Observable.Return(true), RxApp.TaskpoolScheduler);
        }
    }
}