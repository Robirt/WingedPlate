using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface IRecipesRepository
{
    public Task<List<RecipeEntity>> GetRecipiesAsync();

    public Task<RecipeEntity?> GetRecipeByIdAsync(int id);

    public Task AddRecipeAsync(RecipeEntity recipe);

    public Task UpdateRecipeAsync(RecipeEntity recipe);

    public Task RemoveRecipeAsync(RecipeEntity recipe);
}
