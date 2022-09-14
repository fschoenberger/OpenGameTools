using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace OpenGameTools.Gui.ViewModel.Quest {
    public interface IStateViewModel {
        public string Name { get; set; }

        public bool IsSelected { get; set; }

        public Point Anchor { get; set; }

        public Point Location { get; set; }
    }

    public abstract class StateViewModelBase : ReactiveObject, IStateViewModel {
        private string _name = "Miau!";
        private bool _isSelected;
        private Point _anchor;
        private Point _location;

        public string Name {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        public bool IsSelected {
            get => _isSelected;
            set => this.RaiseAndSetIfChanged(ref _isSelected, value);
        }

        public Point Anchor {
            get => _anchor;
            set => this.RaiseAndSetIfChanged(ref _anchor, value);
        }

        public Point Location {
            get => _location;
            set => this.RaiseAndSetIfChanged(ref _location, value);
        }
    }
}