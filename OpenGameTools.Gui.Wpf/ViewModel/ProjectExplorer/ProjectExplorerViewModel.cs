using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenGameTools.Gui.ViewModel.ProjectExplorer;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.ViewModel.ProjectExplorer {
    public class ProjectExplorerViewModel : ReactiveObject, IProjectExplorerViewModel {
        private static readonly Guid _id = Guid.NewGuid();

        public Guid Id => _id;

        public string FriendlyName => "Project Explorer";
    }
}