using DependencyInjectionPractice.Interfaces;

namespace DependencyInjectionPractice.Models
{
    public class Dependencies : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public Dependencies() : this(Guid.NewGuid())
        {

        }
        public Guid GuidId { get; private set; }
        public Dependencies(Guid guid) => GuidId = guid;

    }
}
