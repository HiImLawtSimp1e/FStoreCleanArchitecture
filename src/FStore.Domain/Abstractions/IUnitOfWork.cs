namespace FStore.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        void Save();
        Task<int> SaveAsync();
    }
}
