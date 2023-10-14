using CodePlusAPI.Models.Domain;

namespace CodePlusAPI.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }

}
