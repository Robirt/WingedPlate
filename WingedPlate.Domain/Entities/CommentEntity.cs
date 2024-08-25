namespace WingedPlate.Domain.Entities;

public class CommentEntity : EntityBase
{
    public string Content { get; set; } = string.Empty;

    public int UserId { get; set; } = 0;

    public UserEntity User { get; set; } = new();

    public int RecipeId { get; set; } = 0;

    public RecipeEntity Recipe { get; set; } = new();
}
