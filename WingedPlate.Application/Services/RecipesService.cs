using WingedPlate.Domain.Entities;
using WingedPlate.Infrastructure.Repositories;

namespace WingedPlate.Application.Services;

public class RecipesService : IRecipesService
{
    private readonly IRecipesRepository _recipesRepository;

    public RecipesService(IRecipesRepository recipesRepository)
    {
        ArgumentNullException.ThrowIfNull(recipesRepository, nameof(recipesRepository));

        _recipesRepository = recipesRepository;
    }

    public async Task<List<RecipeEntity>> GetRecipiesAsync(CancellationToken cancellationToken)
    {
        return await _recipesRepository.GetRecipiesAsync(cancellationToken);
    }

    public async Task<RecipeEntity?> GetRecipeByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _recipesRepository.GetRecipeByIdAsync(id, cancellationToken);
    }

    public async Task AddRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken)
    {
        await _recipesRepository.AddRecipeAsync(recipe, cancellationToken);
    }

    public async Task UpdateRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken)
    {
        await _recipesRepository.UpdateRecipeAsync(recipe, cancellationToken);
    }

    public async Task RemoveRecipeAsync(int id, CancellationToken cancellationToken)
    {
        await _recipesRepository.RemoveRecipeAsync((await _recipesRepository.GetRecipeByIdAsync(id, cancellationToken))!, cancellationToken);
    }
}
