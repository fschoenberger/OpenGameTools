using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;

namespace OpenGameTools.Gui.ViewModel.Quest {
    public class QuestDocumentViewModel: ReactiveObject, IDocumentViewModel {
        public QuestDocumentViewModel() {
            _createTransition = ReactiveCommand.Create((ValueTuple<object, object?> tuple) => {
                if (tuple.Item1 is IStateViewModel source && tuple.Item2 is IStateViewModel target) {
                    _transitions.Add(new TransitionViewModel(source, target));
                }
            }, Observable.Return(true));

            _transitions = new ObservableCollection<TransitionViewModel> {};
        }

        private readonly Guid _id = Guid.NewGuid();

        public Guid Id => _id;

        public string FriendlyName => "Beyond the Beef";

        public string Path => "Foo/Bar/Baz";

        public IEnumerable<IStateViewModel> States { get; } = new ObservableCollection<IStateViewModel> {
            new EntryPointViewModel(),
            new StateViewModel(),
            new StateViewModel(),
            //new StateViewModel(),
            //new StateViewModel(),
            new ExitPointViewModel()
        };

        private readonly ObservableCollection<TransitionViewModel> _transitions;

        public IEnumerable<TransitionViewModel> Transitions => _transitions;

        private readonly ReactiveCommand<ValueTuple<object, object?>, Unit> _createTransition;
        public ICommand CreateTransition => _createTransition;
    }
}
