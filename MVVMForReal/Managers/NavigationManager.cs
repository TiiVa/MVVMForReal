using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMForReal.Managers;

public class NavigationManager : INavigationManager
{
    private ObservableObject _currentViewModel;

    public ObservableObject CurrentViewModel
    {
        get
        {
            return _currentViewModel; 
        }
        set
        {
            _currentViewModel = value; 
            OnCurrentViewModelChanged();
        }
    }

    public event Action? CurrentViewModelChanged;

    public void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}