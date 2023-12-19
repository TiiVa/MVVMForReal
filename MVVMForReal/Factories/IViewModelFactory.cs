namespace MVVMForReal.Factories;

public interface IViewModelFactory<out TViewModel>
{
    TViewModel Create();
}