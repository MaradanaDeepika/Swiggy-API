using Swiggy_API.Core.IServices;
using Swiggy_API.Data;
using Swiggy_API.Model;

namespace Swiggy_API.Core.Services
{
    public class ProductServices : IProductServices
    {
        
        private readonly SwiggyDbContext model;

        public ProductServices(SwiggyDbContext Model)
        {
            this.model = Model;
        }

        List<ProductModel> IProductServices.GetProducts()
        {
            return model.productModels.ToList();
        }
      public string PostProduct(ProductModel productModels)
        {
            try
            {
                if (productModels != null)
                {
                    model.productModels.Add(productModels);
                    model.SaveChanges();
                    return "Product Inserted Successfully";
                }
                else
                {
                    return "Product Insertion Failed";
                }
            }
            catch (Exception ex)
            {
               return ex.Message;
            }
        
        }
        public string DeleteProduct(int ProductId, ProductModel productModels)
        {
            try
            {
                if (productModels != null)
                {
                    ProductModel product = new ProductModel();
                    var p = model.productModels.FirstOrDefault(p => p.ProductId == ProductId);
                    model.Remove(product);
                    model.SaveChanges();
                    return "Product deleted successfully";
                }
                else
                    return "Product deletion failed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
           
        public string PutProduct(int ProductId, ProductModel productModels)
        {
            try
            {
                if(productModels != null)
                {
                    ProductModel product = new ProductModel();
                    var p = model.productModels.FirstOrDefault(p => p.ProductId == ProductId);
                    p.Category = productModels.Category;
                    p.Name = productModels.Name;
                    p.Description = productModels.Description;
                    p.Price = productModels.Price;
                    p.Quantity = productModels.Quantity;
                    p.IsActive = productModels.IsActive;
                        model.SaveChanges();
                    return "Updated Successfully";
                }
                else
                {
                    return "product updation failed";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
