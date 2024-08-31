using WingedPlate.Domain.Entities;
using WingedPlate.Infrastructure.Repositories;

namespace WingedPlate.Application.Services;

public class CommentsService : ICommentsService
{
    private readonly ICommentsRepository _commentsRepository;

    public CommentsService(ICommentsRepository commentsRepository)
    {
        ArgumentNullException.ThrowIfNull(commentsRepository, nameof(commentsRepository));

        _commentsRepository = commentsRepository;
    }

    public async Task<List<CommentEntity>> GetCommentsAsync(CancellationToken cancellationToken)
    {
        return await _commentsRepository.GetCommentsAsync(cancellationToken);
    }

    public async Task<CommentEntity?> GetCommentByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _commentsRepository.GetCommentByIdAsync(id, cancellationToken);
    }

    public async Task AddCommentAsync(CommentEntity comment, CancellationToken cancellationToken)
    {
        await _commentsRepository.AddCommentAsync(comment, cancellationToken);   
    }

    public async Task UpdateCommentAsync(CommentEntity comment, CancellationToken cancellationToken)
    {
        await _commentsRepository.UpdateCommentAsync(comment,cancellationToken);    
    }

    public async Task RemoveCommentAsync(int id, CancellationToken cancellationToken)
    {
        await _commentsRepository.RemoveCommentAsync((await _commentsRepository.GetCommentByIdAsync(id, cancellationToken))!, cancellationToken);
    }
}
