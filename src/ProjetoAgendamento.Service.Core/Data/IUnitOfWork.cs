

namespace ProjetoAgendamento.Service.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
