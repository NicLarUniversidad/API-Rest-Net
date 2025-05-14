
using Models.Entities;

namespace APIRest.Repositories.Database.Metadata.Repositories
{
    public class CategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
            this.Context = context;
        }

        private readonly AppDbContext Context;

    }
}
