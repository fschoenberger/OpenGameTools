using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace OpenGameTools.Gui.ViewModel.QuestDocument
{
    public class QuestDocumentViewModel: ReactiveObject, IDocumentViewModel {
        private readonly Guid _id = Guid.NewGuid();

        public Guid Id => _id;

        public string FriendlyName => "Beyond the Beef";

        public string Path => "Foo/Bar/Baz";
    }
}
