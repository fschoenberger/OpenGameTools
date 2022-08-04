using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace OpenGameTools.Gui.ViewModel {
    public interface IMainWindowViewModel: IReactiveObject {
        IReadOnlyList<IDocumentViewModel> DocumentViewModels { get; }
        IList<IToolViewModel> VisibleToolViewModels { get; }
    }
}