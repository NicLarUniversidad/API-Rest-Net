using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace APIRest.Repositories.Database.Metadata.Repositories
{
    public interface IProductRepository : IGenericRepository<ProductEntity>
    {
        ProductEntity GetFileById(Guid id);
    }
}
