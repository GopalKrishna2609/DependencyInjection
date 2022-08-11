namespace DependencyInjectionPractice.Interfaces
{
    public interface IOperationInterface
    {
        Guid GuidId { get; }
    }
    public interface IOperationTransient : IOperationInterface
    { }
    public interface IOperationScoped : IOperationInterface
    { }
    public interface IOperationSingleton : IOperationInterface
    { }
}
