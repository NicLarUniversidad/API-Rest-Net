using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIRest.Domains.DataTransferObjects;

namespace APIRest.Domains.Services
{
    public interface IProductService
    {
        void CreateFile(AddProductDto file);
        ProductDto GetFile(Guid fileId);
    }
}
