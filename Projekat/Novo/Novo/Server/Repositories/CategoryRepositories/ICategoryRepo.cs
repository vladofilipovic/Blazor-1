using Novo.Shared.DTO;
using Novo.Shared.Models;

namespace Novo.Server.Repositories.CategoryRepositories
{
    public interface ICategoryRepo
    {
        Task<ServiceModel<Category>> AddCategory(Category newCategory);
        Task<ServiceModel<Category>> DeleteCategory(int id);
        Task<ServiceModel<Category>> UpdateCategory(Category newCategory);
        Task<ServiceModel<Category>> GetCategory(int id);
        Task<ServiceModel<Category>> GetCategories();
    }
}
