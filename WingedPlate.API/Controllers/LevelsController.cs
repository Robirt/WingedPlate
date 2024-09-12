using Microsoft.AspNetCore.Mvc;
using WingedPlate.Application.Services;
using WingedPlate.Domain.Entities;

namespace WingedPlate.API.Controllers;

[ApiController]
[Route("[controller]")]
public class LevelsController : ControllerBase
{
    private readonly ILevelsService _levelsService;

    public LevelsController(ILevelsService levelsService)
    {
        ArgumentNullException.ThrowIfNull(levelsService, nameof(levelsService));

        _levelsService = levelsService;
    }

    [HttpGet]
    public async Task<List<LevelEntity>> GetLevelsAsync(CancellationToken cancellationToken)
    {
        return await _levelsService.GetLevelsAsync(cancellationToken);
    }

    [HttpGet("id")]
    public async Task<LevelEntity?> GetLevelByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _levelsService.GetLevelByIdAsync(id, cancellationToken);
    }

    [HttpPost]
    public async Task AddLevelAsync(LevelEntity level, CancellationToken cancellationToken)
    {
        await _levelsService.AddLevelAsync(level, cancellationToken);
    }

    [HttpPut]
    public async Task UpdateLevelAsync(LevelEntity level, CancellationToken cancellationToken)
    {
        await _levelsService.UpdateLevelAsync(level, cancellationToken);
    }

    [HttpDelete("id")]
    public async Task RemoveLevelAsync(int id, CancellationToken cancellationToken)
    {
        await _levelsService.RemoveLevelAsync(id, cancellationToken);
    }
}
