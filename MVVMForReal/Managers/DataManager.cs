using MVVMForReal.Models;

namespace MVVMForReal.Managers;

public class DataManager : IDataManager
{
    private readonly DataModel _dataModel = new DataModel();
    public DataModel DataModel => _dataModel;
}