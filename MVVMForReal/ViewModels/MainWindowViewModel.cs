using CommunityToolkit.Mvvm.ComponentModel;
using MVVMForReal.Managers;
using MVVMForReal.Models;

namespace MVVMForReal.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private readonly IDataManager _dataManager;

    private readonly DataModel _dataModel;

    private int _counter;

    public int Counter
    {
        get => _counter;
        set => SetProperty(ref _counter, value);
    }

    public MainWindowViewModel(IDataManager dataManager)
    {
        _dataManager = dataManager;
        _dataModel = _dataManager.DataModel;
    }
}