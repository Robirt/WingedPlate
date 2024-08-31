using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class MealTypesRepository : IMealTypesRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public MealTypesRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<MealTypeEntity>> GetMealTypesAsync()
    {
        return await _wingedPlateDbContext.Meals.Include(mealTypes => mealTypes.Recipes).ToListAsync();
    }

    public async Task<MealTypeEntity?> GetMealTypeByIdAsync(int id)
    {
        return await _wingedPlateDbContext.Meals.Include(mealTypes => mealTypes.Recipes).SingleOrDefaultAsync(mealtype => mealtype.Id == id);
    }

    public async Task AddMealTypeAsync(MealTypeEntity mealtype)
    {
        await _wingedPlateDbContext.Meals.AddAsync(mealtype);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task UpdateMealTypeAsync(MealTypeEntity mealtype)
    {
        _wingedPlateDbContext.Meals.Update(mealtype);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task RemoveMealTypeAsync(MealTypeEntity mealtype)
    {
        _wingedPlateDbContext.Meals.Remove(mealtype);
        await _wingedPlateDbContext.SaveChangesAsync();
    }
}
