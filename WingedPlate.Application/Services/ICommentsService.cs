using WingedPlate.Domain.Entities;

namespace WingedPlate.Application.Services;

public interface ICommentsService
{
    public Task<List<CommentEntity>> GetCommentsAsync(CancellationToken cancellationToken);

    public Task<CommentEntity?> GetCommentByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddCommentAsync(CommentEntity comment, CancellationToken cancellationToken);

    public Task UpdateCommentAsync(CommentEntity comment, CancellationToken cancellationToken);

    public Task RemoveCommentAsync(int id, CancellationToken cancellationToken);
}
