namespace WingedPlate.Domain.Entities;

public class LevelEntity : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public List<RecipeEntity> Recipes { get; set; } = [];
}
