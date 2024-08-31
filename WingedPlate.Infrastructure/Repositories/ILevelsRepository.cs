using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface ILevelsRepository
{
    public Task<List<LevelEntity>> GetLevelsAsync(CancellationToken cancellationToken);

    public Task<LevelEntity?> GetLevelByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddLevelAsync(LevelEntity level, CancellationToken cancellationToken);

    public Task UpdateLevelAsync(LevelEntity level, CancellationToken cancellationToken);

    public Task RemoveLevelAsync(LevelEntity level, CancellationToken cancellationToken);
}
