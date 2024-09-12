using Microsoft.AspNetCore.Mvc;
using WingedPlate.Application.Services;
using WingedPlate.Domain.Entities;

namespace WingedPlate.API.Controllers;

[ApiController]
[Route("[controller]")]
public class MealTypesController : ControllerBase
{
    private readonly IMealTypesService _mealTypesService;

    public MealTypesController(IMealTypesService mealTypesService)
    {
        ArgumentNullException.ThrowIfNull(mealTypesService, nameof(mealTypesService));

        _mealTypesService = mealTypesService;
    }

    [HttpGet]
    public async Task<List<MealTypeEntity>> GetMealTypesAsync(CancellationToken cancellationToken)
    {
        return await _mealTypesService.GetMealTypesAsync(cancellationToken);
    }

    [HttpGet("id")]
    public async Task<MealTypeEntity?> GetMealTypeByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _mealTypesService.GetMealTypeByIdAsync(id, cancellationToken);
    }

    [HttpPost]
    public async Task AddMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken)
    {
        await _mealTypesService.AddMealTypeAsync(mealtype, cancellationToken);
    }

    [HttpPut]
    public async Task UpdateMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken)
    {
        await _mealTypesService.UpdateMealTypeAsync(mealtype, cancellationToken);
    }

    [HttpDelete("id")]
    public async Task RemoveMealTypeAsync(int id, CancellationToken cancellationToken)
    {
        await _mealTypesService.RemoveMealTypeAsync(id, cancellationToken);

    }
}
