using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenGameTools.Gui.ViewModel.Quest;
using ReactiveUI;

namespace OpenGameTools.Gui.Wpf.View.QuestDocument
{
    /// <summary>
    /// Interaction logic for EntryPointViewModel.xaml
    /// </summary>
    public partial class EntryPoint : ReactiveUserControl<EntryPointViewModel>, IComponentConnector {
        public EntryPoint() {
            InitializeComponent();
            this.WhenActivated(d => {
                d(this.Bind(ViewModel, vm => vm.Name, view => view.StateName.Text));
            });
        }
    }
}
