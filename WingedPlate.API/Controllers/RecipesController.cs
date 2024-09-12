using Microsoft.AspNetCore.Mvc;
using WingedPlate.Application.Services;
using WingedPlate.Domain.Entities;

namespace WingedPlate.API.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipesController : ControllerBase
{
    private readonly IRecipesService _recipesService;

    public RecipesController(IRecipesService recipesService)
    {
        ArgumentNullException.ThrowIfNull(recipesService, nameof(recipesService));

        _recipesService = recipesService;
    }

    [HttpGet]
    public async Task<List<RecipeEntity>> GetRecipiesAsync(CancellationToken cancellationToken)
    {
        return await _recipesService.GetRecipiesAsync(cancellationToken);
    }

    [HttpGet("id")]
    public async Task<RecipeEntity?> GetRecipeByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _recipesService.GetRecipeByIdAsync(id, cancellationToken);
    }

    [HttpPost]
    public async Task AddRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken)
    {
        await _recipesService.AddRecipeAsync(recipe, cancellationToken);
    }

    [HttpPut]
    public async Task UpdateRecipeAsync(RecipeEntity recipe, CancellationToken cancellationToken)
    {
        await _recipesService.UpdateRecipeAsync(recipe, cancellationToken);
    }

    [HttpDelete("id")]
    public async Task RemoveRecipeAsync(int id, CancellationToken cancellationToken)
    {
        await _recipesService.RemoveRecipeAsync(id, cancellationToken);
    }
}
