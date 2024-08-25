namespace WingedPlate.Domain.Entities;

public class MealTypeEntity : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public List<RecipeEntity> Recipes { get; set; } = [];
}
