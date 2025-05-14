using AutoMapper;
using APIRest.Domains.DataTransferObjects;
using APIRest.Repositories.Database.Metadata;
using Models.Entities;

namespace APIRest.Domains.Services
{
    public class ProductService : IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper) { 
            this.UnitOfWork = unitOfWork;
            this.Mapper = mapper;
        }

        private IUnitOfWork UnitOfWork;
        private IMapper Mapper;

        public void CreateFile(AddProductDto file)
        {
            var newFileEntity = this.Mapper.Map<ProductEntity>(file); // ProductEntity
            UnitOfWork.ProductRepository.Insert(newFileEntity);
        }

        public ProductDto GetFile(Guid fileId)
        {
            var fileEntity = UnitOfWork.ProductRepository.GetFileById(fileId);
            if (fileEntity != null)
            {
                var fileDto = this.Mapper.Map<ProductDto>(fileEntity); // ProductDto
                return fileDto;
            }
            return null;
        }
    }
}
