using RealEstateDapperApi.Dtos.CategoryDtos;

namespace RealEstateDapperApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
    }
}
