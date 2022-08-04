using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameTools.Gui.ViewModel {
    public interface IToolViewModel {
        public Guid Id { get; }

        public string FriendlyName { get; }
    }
}