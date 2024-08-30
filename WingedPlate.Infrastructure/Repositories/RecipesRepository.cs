using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class RecipesRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public RecipesRepository(WingedPlateDbContext wingedPlateDbContext) 
    {
        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<RecipeEntity>> GetRecipiesAsync()
    {
        return await _wingedPlateDbContext.Recipes.Include(recipies => recipies.Tags).Include(recipies => recipies.Level).Include(recipies => recipies.MealTypes).Include(recipies => recipies.Categories).Include(recipies => recipies.Comments).ToListAsync(); 
    }

    public async Task<RecipeEntity?> GetRecipeByIdAsync(int id)
    {
        return await _wingedPlateDbContext.Recipes.Include(recipies => recipies.Tags).Include(recipies => recipies.Level).Include(recipies => recipies.MealTypes).Include(recipies => recipies.Categories).Include(recipies => recipies.Comments).SingleOrDefaultAsync(recipe => recipe.Id == id);
    }

    public async Task AddRecipeAsync(RecipeEntity recipe)
    {
        await _wingedPlateDbContext.Recipes.AddAsync(recipe);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task UpdateRecipeAsync(RecipeEntity recipe)
    {
        _wingedPlateDbContext.Recipes.Update(recipe);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task RemoveRecipeAsync(RecipeEntity recipe)
    {
        _wingedPlateDbContext.Recipes.Remove(recipe);
        await _wingedPlateDbContext.SaveChangesAsync();
    }
}
