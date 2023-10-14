using CodePlusAPI.Data;
using CodePlusAPI.Models.Domain;
using CodePlusAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CodePlusAPI.Repositories.Implimentation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AplicationDbContext dbContext;
        public CategoryRepository(AplicationDbContext dbContext) 
        { 
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Category.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
