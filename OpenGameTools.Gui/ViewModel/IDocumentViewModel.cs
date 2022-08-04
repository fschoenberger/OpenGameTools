using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameTools.Gui.ViewModel {
    public interface IDocumentViewModel {
        Guid Id { get; }

        string FriendlyName { get; }

        string Path { get; }
    }
}