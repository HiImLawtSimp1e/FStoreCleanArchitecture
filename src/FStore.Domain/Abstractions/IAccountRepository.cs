using FStore.Domain.UserIdentity;

namespace FStore.Domain.Abstractions
{
    public interface IAccountRepository : IRepository<Account>
    {
        void Update(Account entity);
    }
}
