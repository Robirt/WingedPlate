using Microsoft.AspNetCore.Mvc;
using WingedPlate.Application.Services;
using WingedPlate.Domain.Entities;

namespace WingedPlate.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentsController : ControllerBase
{
    private readonly ICommentsService _commentsService;

    public CommentsController(ICommentsService commentsService)
    {
        ArgumentNullException.ThrowIfNull(commentsService, nameof(commentsService));

        _commentsService = commentsService;
    }

    [HttpGet]
    public async Task<List<CommentEntity>> GetCommentsAsync(CancellationToken cancellationToken)
    {
        return await _commentsService.GetCommentsAsync(cancellationToken);
    }

    [HttpGet("id")]
    public async Task<CommentEntity?> GetCommentByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _commentsService.GetCommentByIdAsync(id, cancellationToken);
    }

    [HttpPost]
    public async Task AddCommentAsync(CommentEntity comment, CancellationToken cancellationToken)
    {
        await _commentsService.AddCommentAsync(comment, cancellationToken);
    }

    [HttpPut]
    public async Task UpdateCommentAsync(CommentEntity comment, CancellationToken cancellationToken)
    {
        await _commentsService.UpdateCommentAsync(comment, cancellationToken);
    }

    [HttpDelete("id")]
    public async Task RemoveCommentAsync(int id, CancellationToken cancellationToken)
    {
        await _commentsService.RemoveCommentAsync(id, cancellationToken);
    }
}
