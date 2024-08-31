using WingedPlate.Domain.Entities;

namespace WingedPlate.Application.Services;

public interface IRecipesService
{
    public Task<List<RecipeEntity>> GetRecipiesAsync(CancellationToken cancellationToken);

    public Task<RecipeEntity?> GetRecipeByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken);

    public Task UpdateRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken);

    public Task RemoveRecipeAsync(int id, CancellationToken cancellationToken);
}
