using WingedPlate.Domain.Entities;
using WingedPlate.Infrastructure.Repositories;

namespace WingedPlate.Application.Services;

public class MealTypesService : IMealTypesService
{
    private readonly IMealTypesRepository _mealTypesRepository;

    public MealTypesService(IMealTypesRepository mealTypesRepository)
    {
        ArgumentNullException.ThrowIfNull(mealTypesRepository, nameof(mealTypesRepository));

        _mealTypesRepository = mealTypesRepository;
    }

    public async Task<List<MealTypeEntity>> GetMealTypesAsync(CancellationToken cancellationToken)
    {
        return await _mealTypesRepository.GetMealTypesAsync(cancellationToken);
    }

    public async Task<MealTypeEntity?> GetMealTypeByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _mealTypesRepository.GetMealTypeByIdAsync(id, cancellationToken);
    }

    public async Task AddMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken)
    {
        await _mealTypesRepository.AddMealTypeAsync(mealtype, cancellationToken);
    }

    public async Task UpdateMealTypeAsync(MealTypeEntity mealtype, CancellationToken cancellationToken)
    {
        await _mealTypesRepository.UpdateMealTypeAsync(mealtype, cancellationToken);
    }

    public async Task RemoveMealTypeAsync(int id, CancellationToken cancellationToken)
    {
        await _mealTypesRepository.RemoveMealTypeAsync((await _mealTypesRepository.GetMealTypeByIdAsync(id, cancellationToken))!, cancellationToken);

    }
}
