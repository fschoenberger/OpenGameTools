using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using OpenGameTools.Gui.ViewModel;

namespace OpenGameTools.Gui.Wpf.Selectors {
    /// <inheritdoc />
    internal class DockingElementStyleSelector : StyleSelector {
        /// <summary>
        /// Gets or sets the style for documents.
        /// </summary>
        public Style DocumentStyle { get; set; }

        /// <summary>
        /// Gets or sets the style for support windows.
        /// </summary>
        public Style ToolPaneStyle { get; set; }

        /// <inheritdoc />
        public override Style? SelectStyle(object item, DependencyObject container) {
            return item switch {
                IDocumentViewModel => DocumentStyle,
                IToolViewModel => ToolPaneStyle,
                _ => base.SelectStyle(item, container)
            };
        }
    }
}