using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface IMealTypesRepository
{
    public Task<List<MealTypeEntity>> GetMealTypesAsync();

    public Task<MealTypeEntity?> GetMealTypeByIdAsync(int id);

    public Task AddMealTypeAsync(MealTypeEntity mealtype);

    public Task UpdateMealTypeAsync(MealTypeEntity mealtype);

    public Task RemoveMealTypeAsync(MealTypeEntity mealtype);
}
