using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class LevelsRepository : ILevelsRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public LevelsRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        ArgumentNullException.ThrowIfNull(wingedPlateDbContext, nameof(wingedPlateDbContext));

        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<LevelEntity>> GetLevelsAsync(CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Levels.Include(levels => levels.Recipes).ToListAsync(cancellationToken);
    }

    public async Task<LevelEntity?> GetLevelByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Levels.Include(levels => levels.Recipes).SingleOrDefaultAsync(level => level.Id == id, cancellationToken);
    }

    public async Task AddLevelAsync(LevelEntity level, CancellationToken cancellationToken)
    {
        await _wingedPlateDbContext.Levels.AddAsync(level, cancellationToken);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateLevelAsync(LevelEntity level, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Levels.Update(level);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveLevelAsync(LevelEntity level, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Levels.Remove(level);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }
}
