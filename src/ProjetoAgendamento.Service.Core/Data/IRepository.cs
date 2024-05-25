

using ProjetoAgendamento.Service.Core.DomainObjects.Interfaces;

namespace ProjetoAgendamento.Service.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
