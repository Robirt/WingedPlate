using WingedPlate.Domain.Entities;

namespace WingedPlate.Application.Services;

public interface ICategoriesService
{
    public Task<List<CategoryEntity>> GetCategoriesAsync(CancellationToken cancellationToken);

    public Task<CategoryEntity?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddCategoryAsync(CategoryEntity category, CancellationToken cancellationToken);

    public Task UpdateCategoryAsync(CategoryEntity category, CancellationToken cancellationToken);

    public Task RemoveCategoryAsync(int id, CancellationToken cancellationToken);
}
