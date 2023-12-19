using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMForReal.Managers;

public interface INavigationManager
{
    ObservableObject CurrentViewModel { get; set; }
    event Action CurrentViewModelChanged;
    void OnCurrentViewModelChanged();
}