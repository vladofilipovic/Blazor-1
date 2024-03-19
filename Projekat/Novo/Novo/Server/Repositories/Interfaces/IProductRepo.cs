using Novo.Shared.DTO;
using Novo.Shared.Models;

namespace Novo.Server.Repositories.Interfaces
{
    public interface IProductRepo
    {
        public Task<ServiceModel<Product>> AddProduct(Product NewProduct);
        public Task<ServiceModel<Product>> UpdateProduct(Product NewProduct);
        public Task<ServiceModel<Product>> GetProducts();
        public Task<ServiceModel<Product>> GetProduct(int ProductId);
        public Task<ServiceModel<Product>> DeleteProduct(int ProductId);
    }
}
