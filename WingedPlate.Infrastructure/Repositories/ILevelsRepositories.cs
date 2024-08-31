using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface ILevelsRepositories
{
    public Task<List<LevelEntity>> GetLevelsAsync();

    public Task<LevelEntity?> GetLevelByIdAsync(int id);

    public Task AddLevelAsync(LevelEntity level);

    public Task UpdateLevelAsync(LevelEntity level);

    public Task RemoveLevelAsync(LevelEntity level);
}
