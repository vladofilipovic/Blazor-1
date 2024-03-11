using Ecommerce.Shared.DTO;
using Ecommerce.Shared.Models;
namespace Ecommerce.Client.Services.InterfaceServices
{
    public interface IProductServices
    {
        public Task<ServiceModel?> AddProduct(Product NewProduct);
        public Task<ServiceModel?> GetProducts();
        public Task<ServiceModel?> GetProduct(int ProductId);
    }
}
