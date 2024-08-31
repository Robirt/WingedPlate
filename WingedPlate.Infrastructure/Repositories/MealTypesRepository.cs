using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class MealTypesRepository : IMealTypesRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public MealTypesRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        ArgumentNullException.ThrowIfNull(wingedPlateDbContext, nameof(wingedPlateDbContext));

        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<MealTypeEntity>> GetMealTypesAsync(CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Meals.Include(mealTypes => mealTypes.Recipes).ToListAsync(cancellationToken);
    }

    public async Task<MealTypeEntity?> GetMealTypeByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Meals.Include(mealTypes => mealTypes.Recipes).SingleOrDefaultAsync(mealtype => mealtype.Id == id, cancellationToken);
    }

    public async Task AddMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken)
    {
        await _wingedPlateDbContext.Meals.AddAsync(mealtype, cancellationToken);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Meals.Update(mealtype);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Meals.Remove(mealtype);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }
}
