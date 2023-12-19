using CommunityToolkit.Mvvm.ComponentModel;
using MVVMForReal.Factories;
using MVVMForReal.Managers;
using MVVMForReal.Models;

namespace MVVMForReal.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private readonly IDataManager _dataManager;
    private readonly INavigationManager _navigationManager;
    private readonly DataModel _dataModel;

    public ObservableObject CurrentViewModel => _navigationManager.CurrentViewModel;
    
    public int Counter
    {
        get => _dataModel.Counter;
        set => 
            SetProperty(
                _dataModel.Counter, 
                value, _dataModel, 
                (model, value)=> model.Counter = value
                );
    }

    public MainWindowViewModel(
        IDataManager dataManager, 
        INavigationManager navigationManager,
        IViewModelFactory<CenterViewModel> centerFactory)
    {
        _dataManager = dataManager;
        _navigationManager = navigationManager;
        _dataModel = _dataManager.DataModel;

        _navigationManager.CurrentViewModel = centerFactory.Create();

        _navigationManager.CurrentViewModelChanged += OnCurrentViewModelChanged;
    }

    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}