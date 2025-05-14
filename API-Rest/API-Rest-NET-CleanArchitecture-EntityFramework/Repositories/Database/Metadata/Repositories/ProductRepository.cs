
using Models.Entities;

namespace APIRest.Repositories.Database.Metadata.Repositories
{
    public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
            this.Context = context;
        }

        private readonly AppDbContext Context;

        /***
         * Puede devolver nulos
         * TODO: Disparar excepción
         */
        public ProductEntity GetFileById(Guid id)
        {
            var file = this.Context.Products.FirstOrDefault(f => f.Id == id);
            return file;
        }
    }
}
