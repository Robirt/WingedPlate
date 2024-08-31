using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class CategoriesRepository : ICategoriesRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public CategoriesRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        ArgumentNullException.ThrowIfNull(wingedPlateDbContext, nameof(wingedPlateDbContext));

        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<CategoryEntity>> GetCategoriesAsync(CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Categories.Include(categories => categories.Recipes).ToListAsync(cancellationToken);
    }

    public async Task<CategoryEntity?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Categories.Include(categories => categories.Recipes).SingleOrDefaultAsync(category => category.Id == id, cancellationToken);
    }

    public async Task AddCategoryAsync(CategoryEntity category, CancellationToken cancellationToken)
    {
        await _wingedPlateDbContext.Categories.AddAsync(category, cancellationToken);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateCategoryAsync(CategoryEntity category, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Categories.Update(category);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveCategoryAsync(CategoryEntity category, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Categories.Remove(category);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }
}
