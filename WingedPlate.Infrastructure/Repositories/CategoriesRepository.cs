using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class CategoriesRepository : ICategoriesRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public CategoriesRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<CategoryEntity>> GetCategoriesAsync()
    {
        return await _wingedPlateDbContext.Categories.Include(categories => categories.Recipes).ToListAsync();
    }

    public async Task<CategoryEntity?> GetCategoryByIdAsync(int id)
    {
        return await _wingedPlateDbContext.Categories.Include(categories => categories.Recipes).SingleOrDefaultAsync(category => category.Id == id);
    }

    public async Task AddCategoryAsync(CategoryEntity category)
    {
        await _wingedPlateDbContext.Categories.AddAsync(category);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task UpdateCategoryAsync(CategoryEntity category)
    {
        _wingedPlateDbContext.Categories.Update(category);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task RemoveCategoryAsync(CategoryEntity category)
    {
        _wingedPlateDbContext.Categories.Remove(category);
        await _wingedPlateDbContext.SaveChangesAsync();
    }
}
