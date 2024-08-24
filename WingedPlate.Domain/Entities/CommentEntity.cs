namespace WingedPlate.Domain.Entities;

public class CommentEntity : EntityBase
{
    public string Content { get; set; } = string.Empty;

    public int UserId { get; set; } = 0;

    public UserEntity User { get; set; } = new();
}
