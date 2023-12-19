using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using MVVMForReal.Factories;

namespace MVVMForReal.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddViewModelFactory<TViewModel>(this IServiceCollection services)
    where TViewModel : ObservableObject
    {
        services.AddTransient<TViewModel>();
        services.AddTransient<Func<TViewModel>>(
            sp =>
                () => sp.GetService<TViewModel>()!);
        services.AddSingleton<IViewModelFactory<TViewModel>, ViewModelFactory<TViewModel>>();
    }
}