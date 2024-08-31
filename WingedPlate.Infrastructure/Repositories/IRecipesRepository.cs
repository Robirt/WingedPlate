﻿using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface IRecipesRepository
{
    public Task<List<RecipeEntity>> GetRecipiesAsync(CancellationToken cancellationToken);

    public Task<RecipeEntity?> GetRecipeByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken);

    public Task UpdateRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken);

    public Task RemoveRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken);
}
