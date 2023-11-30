
namespace Logistica.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        // tratando operações a transação
        Task Commit(CancellationToken cancellationToken);
    }
}
