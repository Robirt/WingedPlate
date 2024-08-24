namespace WingedPlate.Domain.Entities;

public class RecipeEntity : EntityBase
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public byte[] Image { get; set; } = [];

    public double PreparationTime { get; set; }

    public int Calories { get; set; }

    public int CaloriesByPortion { get; set; }

    public decimal ProteinByPortion { get; set; } 

    public decimal FatByPortion { get; set; }

    public decimal CarbohydratesByPortion { get; set; }

    public int PortionsCount { get; set; }  

    public int LevelId { get; set; } = 0;

    public LevelEntity Level { get; set; } = new(); 

    public List<string> Ingredients { get; set; } = [];

    public List<string> Instructions { get; set; } = [];

    public List<TagEntity> Tags { get; set; } = [];

    public List<MealTypeEntity> MealTypes { get; set; } = [];

    public List<CategoryEntity> Categories { get; set; } = [];

    public List<CommentEntity> Comments { get; set; } = [];
}
