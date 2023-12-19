using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMForReal.Factories;
using MVVMForReal.Managers;

namespace MVVMForReal.ViewModels;

public class CenterViewModel : ObservableObject
{
    private readonly INavigationManager _navigationManager;

    public IRelayCommand NavigateLeftCommand { get; }

    public CenterViewModel(
        INavigationManager navigationManager,
        IViewModelFactory<LeftViewModel> leftFactory)
    {
        _navigationManager = navigationManager;

        NavigateLeftCommand = new RelayCommand(
            () => 
                    _navigationManager.CurrentViewModel = leftFactory.Create()
                );
    }
}