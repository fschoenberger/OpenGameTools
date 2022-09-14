using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace OpenGameTools.Gui.ViewModel.Quest {
    public class TransitionViewModel: ReactiveObject {
        private IStateViewModel _source;

        private IStateViewModel _target;

        private bool _isActive;

        public IStateViewModel Source {
            get => _source;
            set => this.RaiseAndSetIfChanged(ref _source, value);
        }

        public IStateViewModel Target {
            get => _target;
            set => this.RaiseAndSetIfChanged(ref _target, value);
        }

        public bool IsActive {
            get => _isActive;
            set => this.RaiseAndSetIfChanged(ref _isActive, value);
        }

        public TransitionViewModel(IStateViewModel source, IStateViewModel target) {
            _source = source;
            _target = target;
        }
    }
}
