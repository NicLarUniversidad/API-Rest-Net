using APIRest.Domains.DataTransferObjects;
using APIRest.Domains.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace APIRest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var file = _productService.GetFile(id);
            if (file == null)
                return NotFound();

            return Ok(file);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddProductDto newProduct)
        {
            _productService.CreateFile(newProduct);
            return Created();
        }
    }
}
