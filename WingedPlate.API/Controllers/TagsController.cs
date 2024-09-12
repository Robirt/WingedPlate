using Microsoft.AspNetCore.Mvc;
using WingedPlate.Application.Services;
using WingedPlate.Domain.Entities;

namespace WingedPlate.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TagsController : ControllerBase
{
    private readonly ITagsService _tagsService;

    public TagsController(ITagsService tagsService)
    {
        ArgumentNullException.ThrowIfNull(tagsService, nameof(tagsService));

        _tagsService = tagsService;
    }

    [HttpGet]
    public async Task<List<TagEntity>> GetTagsAsync(CancellationToken cancellationToken)
    {
        return await _tagsService.GetTagsAsync(cancellationToken);
    }

    [HttpGet("id")]
    public async Task<TagEntity?> GetTagByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _tagsService.GetTagByIdAsync(id, cancellationToken);
    }

    [HttpPost]
    public async Task AddTagAsync(TagEntity tag, CancellationToken cancellationToken)
    {
        await _tagsService.AddTagAsync(tag, cancellationToken);
    }

    [HttpPut]
    public async Task UpdateTagAsync(TagEntity tag, CancellationToken cancellationToken)
    {
        await _tagsService.UpdateTagAsync(tag, cancellationToken);
    }

    [HttpDelete("id")]
    public async Task RemoveTagAsync(int id, CancellationToken cancellationToken)
    {
        await _tagsService.RemoveTagAsync(id, cancellationToken);
    }
}
