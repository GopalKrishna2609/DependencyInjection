using DependencyInjectionPractice.Interfaces;

namespace DependencyInjectionPractice.Models
{
    public class Dependencies : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        Guid _guid;
        public Dependencies() : this(Guid.NewGuid())
        {

        }

        public Dependencies(Guid guid)
        {
            _guid = guid;
        }

        public Guid OperationId => _guid;

        public Guid GuidId => throw new NotImplementedException();
    }
}
