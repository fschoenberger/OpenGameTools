using System.Windows.Input;
using ReactiveUI;

namespace OpenGameTools.Gui.ViewModel;

/// <summary>
/// 
/// </summary>
public interface IDockViewModel : IReactiveObject {
    ICommand LoadLayoutCommand { get; }

    ICommand SaveLayoutCommand { get; }
}