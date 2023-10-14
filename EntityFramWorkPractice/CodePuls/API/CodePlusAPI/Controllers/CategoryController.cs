using CodePlusAPI.Data;
using CodePlusAPI.Models.Domain;
using CodePlusAPI.Models.DTO;
using CodePlusAPI.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace CodePlusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository; 
        public CategoryController(ICategoryRepository categoryRepository) 
        { 
            this.categoryRepository = categoryRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            var category = new Category
            {
                Name = request.Name,
                UrlHandel = request.UrlHandel
            };

            await categoryRepository.CreateAsync(category);

            var response = new CategoryDTO
            {
                ID = category.ID,
                Name = category.Name,
                UrlHandel  = category.UrlHandel
            };
            return Ok(category);
        }
    }
}
