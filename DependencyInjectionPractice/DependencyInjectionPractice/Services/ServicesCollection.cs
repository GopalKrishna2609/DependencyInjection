using DependencyInjectionPractice.Interfaces;
using DependencyInjectionPractice.Models;

namespace DependencyInjectionPractice.Services
{
    public static class ServicesCollection
    {
        public static void AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddTransient<IOperationTransient, Dependencies>();
            serviceDescriptors.AddTransient<IOperationScoped, Dependencies>();
            serviceDescriptors.AddTransient<IOperationSingleton, Dependencies>();

        }
    }
}
