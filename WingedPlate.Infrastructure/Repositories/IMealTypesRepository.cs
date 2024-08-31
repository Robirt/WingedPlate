﻿using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface IMealTypesRepository
{
    public Task<List<MealTypeEntity>> GetMealTypesAsync(CancellationToken cancellationToken);

    public Task<MealTypeEntity?> GetMealTypeByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken);

    public Task UpdateMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken);

    public Task RemoveMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken);
}
