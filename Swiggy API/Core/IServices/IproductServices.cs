using Swiggy_API.Model;

namespace Swiggy_API.Core.IServices
{
    public interface IProductServices
    {
        List<ProductModel> GetProducts();

        string PostProduct(ProductModel productModels);
        string DeleteProduct(int ProductId, ProductModel productModels);
        string PutProduct(int ProductId, ProductModel productModels);
    }
}
