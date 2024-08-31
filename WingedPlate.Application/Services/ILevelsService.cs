using WingedPlate.Domain.Entities;

namespace WingedPlate.Application.Services;

public interface ILevelsService
{
    public Task<List<LevelEntity>> GetLevelsAsync(CancellationToken cancellationToken);

    public Task<LevelEntity?> GetLevelByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddLevelAsync(LevelEntity level, CancellationToken cancellationToken);

    public Task UpdateLevelAsync(LevelEntity level, CancellationToken cancellationToken);

    public Task RemoveLevelAsync(int id, CancellationToken cancellationToken);
}
