namespace FStore.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IAccountRepository Account { get; }
        void Save();
        Task<int> SaveAsync();
    }
}
