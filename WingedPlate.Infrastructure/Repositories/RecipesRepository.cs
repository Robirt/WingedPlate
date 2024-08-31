using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class RecipesRepository : IRecipesRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public RecipesRepository(WingedPlateDbContext wingedPlateDbContext) 
    {
        ArgumentNullException.ThrowIfNull(wingedPlateDbContext, nameof(wingedPlateDbContext));

        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<RecipeEntity>> GetRecipiesAsync(CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Recipes.Include(recipies => recipies.Tags).Include(recipies => recipies.Level).Include(recipies => recipies.MealTypes).Include(recipies => recipies.Categories).Include(recipies => recipies.Comments).ToListAsync(cancellationToken); 
    }

    public async Task<RecipeEntity?> GetRecipeByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Recipes.Include(recipies => recipies.Tags).Include(recipies => recipies.Level).Include(recipies => recipies.MealTypes).Include(recipies => recipies.Categories).Include(recipies => recipies.Comments).SingleOrDefaultAsync(recipe => recipe.Id == id , cancellationToken);
    }

    public async Task AddRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken)
    {
        await _wingedPlateDbContext.Recipes.AddAsync(recipe, cancellationToken);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Recipes.Update(recipe);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Recipes.Remove(recipe);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }
}
