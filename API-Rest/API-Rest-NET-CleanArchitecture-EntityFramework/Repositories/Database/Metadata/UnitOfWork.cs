using APIRest.Repositories.Database.Metadata.Repositories;
using Microsoft.EntityFrameworkCore;

namespace APIRest.Repositories.Database.Metadata
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {

        private AppDbContext context;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;

        public UnitOfWork(AppDbContext _context)
        {
            context = _context;
        }

        public IProductRepository ProductRepository
        {
            get
            {

                if (this._productRepository == null)
                {
                    this._productRepository = new ProductRepository(context);
                }
                return _productRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {

                if (this._categoryRepository == null)
                {
                    this._categoryRepository = new CategoryRepository(context);
                }
                return _categoryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<int> CompleteAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
