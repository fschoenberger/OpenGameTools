using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using OpenGameTools.Gui.ViewModel;
using OpenGameTools.Gui.ViewModel.Quest;

namespace OpenGameTools.Gui.Wpf.Selectors {
    public class StateMachineTemplateSelector: DataTemplateSelector {
        public DataTemplate Choice { get; set; }

        public DataTemplate Compound { get; set; }

        public DataTemplate ConcurrentRegion { get; set; }

        public DataTemplate EntryPoint { get; set; }

        public DataTemplate ExitPoint { get; set; }

        public DataTemplate Fork { get; set; }

        public DataTemplate History { get; set; }

        public DataTemplate Join { get; set; }

        public DataTemplate Junction { get; set; }

        public DataTemplate State { get; set; }

        public DataTemplate Terminate { get; set; }

        /// <inheritdoc />
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            return item switch {
                ChoiceViewModel => Choice,
                CompoundStateViewModel => Compound,
                ConcurrentRegionViewModel => ConcurrentRegion,
                EntryPointViewModel => EntryPoint,
                ExitPointViewModel => ExitPoint,
                ForkViewModel => Fork,
                HistoryViewModel => History,
                JoinViewModel => Join,
                JunctionViewModel => Junction,
                StateViewModel => State,
                TerminateViewModel => Terminate,
                _ => base.SelectTemplate(item, container)
            };
        }
    }
}
