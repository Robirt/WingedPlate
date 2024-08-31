using WingedPlate.Domain.Entities;
using WingedPlate.Infrastructure.Repositories;

namespace WingedPlate.Application.Services;

public class CategoriesService : ICategoriesService
{
    private readonly ICategoriesRepository _categoriesRepository;

    public CategoriesService(ICategoriesRepository categoriesRepository) 
    {
        ArgumentNullException.ThrowIfNull(categoriesRepository, nameof(categoriesRepository));

        _categoriesRepository = categoriesRepository;
    }  

    public async Task<List<CategoryEntity>> GetCategoriesAsync(CancellationToken cancellationToken)
    {
        return await _categoriesRepository.GetCategoriesAsync(cancellationToken);
    }

    public async Task<CategoryEntity?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _categoriesRepository.GetCategoryByIdAsync(id, cancellationToken);
    }

    public async Task AddCategoryAsync(CategoryEntity category, CancellationToken cancellationToken)
    {
        await _categoriesRepository.AddCategoryAsync(category, cancellationToken);
    }

    public async Task UpdateCategoryAsync(CategoryEntity category, CancellationToken cancellationToken)
    {
        await _categoriesRepository.UpdateCategoryAsync(category, cancellationToken);
    }

    public async Task RemoveCategoryAsync(int id, CancellationToken cancellationToken)
    {
        await _categoriesRepository.RemoveCategoryAsync((await _categoriesRepository.GetCategoryByIdAsync(id, cancellationToken))!, cancellationToken);
    }
}
