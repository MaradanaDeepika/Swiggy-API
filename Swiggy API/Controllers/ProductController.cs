using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swiggy_API.Core.IServices;
using Swiggy_API.Core.Services;
using Swiggy_API.Model;

namespace Swiggy_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices productservice;

        public ProductController(IProductServices _productservice)
        {
           this.productservice = _productservice;
        }
        [HttpGet]
        [Route("Read")]
        public List<ProductModel> GetProduct()
        {
            return productservice.GetProducts();
        }
        [HttpPost]
        public string PostProduct([FromBody] ProductModel productModels)
        {
            return productservice.PostProduct(productModels);
        }
        [HttpPut]
        public string PutProduct(int ProductId, [FromBody] ProductModel productModels)
        {
            return productservice.PutProduct(ProductId, productModels);

        }
        [HttpDelete]
        public string DeleteProduct(int ProductId, [FromBody] ProductModel productModels)
        {
            return productservice.DeleteProduct(ProductId, productModels);
        }
    }

}
