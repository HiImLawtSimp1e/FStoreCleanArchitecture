using FStore.Domain.Catalog;

namespace FStore.Domain.Abstractions
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category entity);
    }
}
