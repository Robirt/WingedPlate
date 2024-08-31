using WingedPlate.Domain.Entities;
using WingedPlate.Infrastructure.Repositories;

namespace WingedPlate.Application.Services;

public class LevelsService : ILevelsService
{
    private readonly ILevelsRepository _levelsRepository;

    public LevelsService(ILevelsRepository levelsRepository)
    {
        ArgumentNullException.ThrowIfNull(levelsRepository, nameof(levelsRepository));

        _levelsRepository = levelsRepository;
    }

    public async Task<List<LevelEntity>> GetLevelsAsync(CancellationToken cancellationToken)
    {
        return await _levelsRepository.GetLevelsAsync(cancellationToken);
    }

    public async Task<LevelEntity?> GetLevelByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _levelsRepository.GetLevelByIdAsync(id, cancellationToken);
    }

    public async Task AddLevelAsync(LevelEntity level, CancellationToken cancellationToken)
    {
        await _levelsRepository.AddLevelAsync(level, cancellationToken);
    }

    public async Task UpdateLevelAsync(LevelEntity level, CancellationToken cancellationToken)
    {
        await _levelsRepository.UpdateLevelAsync(level, cancellationToken);
    }

    public async Task RemoveLevelAsync(int id, CancellationToken cancellationToken)
    {
        await _levelsRepository.RemoveLevelAsync((await _levelsRepository.GetLevelByIdAsync(id, cancellationToken))!, cancellationToken);
    }
}
