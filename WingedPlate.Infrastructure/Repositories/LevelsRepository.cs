using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class LevelsRepository : ILevelsRepositories
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public LevelsRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<LevelEntity>> GetLevelsAsync()
    {
        return await _wingedPlateDbContext.Levels.Include(levels => levels.Recipes).ToListAsync();
    }

    public async Task<LevelEntity?> GetLevelByIdAsync(int id)
    {
        return await _wingedPlateDbContext.Levels.Include(levels => levels.Recipes).SingleOrDefaultAsync(level => level.Id == id);
    }

    public async Task AddLevelAsync(LevelEntity level)
    {
        await _wingedPlateDbContext.Levels.AddAsync(level);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task UpdateLevelAsync(LevelEntity level)
    {
        _wingedPlateDbContext.Levels.Update(level);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task RemoveLevelAsync(LevelEntity level)
    {
        _wingedPlateDbContext.Levels.Remove(level);
        await _wingedPlateDbContext.SaveChangesAsync();
    }
}
