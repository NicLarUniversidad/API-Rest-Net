using APIRest.Repositories.Database.Metadata.Repositories;

namespace APIRest.Repositories.Database.Metadata
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        Task<int> CompleteAsync();
    }
}
