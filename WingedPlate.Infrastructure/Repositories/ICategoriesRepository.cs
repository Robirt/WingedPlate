using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface ICategoriesRepository
{
    public Task<List<CategoryEntity>> GetCategoriesAsync();

    public Task<CategoryEntity?> GetCategoryByIdAsync(int id);

    public Task AddCategoryAsync(CategoryEntity category);

    public Task UpdateCategoryAsync(CategoryEntity category);

    public Task RemoveCategoryAsync(CategoryEntity category);
}
