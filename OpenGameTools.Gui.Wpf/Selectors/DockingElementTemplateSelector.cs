using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using OpenGameTools.Gui.ViewModel;

namespace OpenGameTools.Gui.Wpf.Selectors {
    /// <summary>
    /// Selects the appropriate data template.
    /// </summary>
    public class DockingElementTemplateSelector : DataTemplateSelector {
        /// <summary>
        /// Gets or sets the data template for branches.
        /// </summary>
        public DataTemplate Template { get; set; }

        /// <inheritdoc />
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            return 
                item is IToolViewModel or IDocumentViewModel 
                    ? Template 
                    : base.SelectTemplate(item, container);
        }
    }
}