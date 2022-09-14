using ReactiveUI;

namespace OpenGameTools.Gui.ViewModel.Quest {
    public class QuestDocumentViewModel: ReactiveObject, IDocumentViewModel {
        public QuestDocumentViewModel() {
            Console.Out.WriteLine("New Document View Model!");
        }

        private readonly Guid _id = Guid.NewGuid();

        public Guid Id => _id;

        public string FriendlyName => "Beyond the Beef";

        public string Path => "Foo/Bar/Baz";

        public IEnumerable<IStateViewModel> States { get; } = new List<IStateViewModel> {
           new EntryPointViewModel(),
           new StateViewModel(),
           new StateViewModel(),
           new ExitPointViewModel()
        };
    }
}
