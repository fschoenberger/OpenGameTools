using System;
using OpenGameTools.Gui.ViewModel;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.ViewModel.DummyDocument {
    public class DummyDocumentViewModel : ReactiveObject, IDocumentViewModel {
        private readonly Guid _id = Guid.NewGuid();

        public Guid Id => _id;

        public string FriendlyName => "Dummy Document";

        public string Path => "Foo/Bar/Baz";
    }
}