import { CategoryEntity } from "./category.entity"
import { CommentEntity } from "./comment.entity"
import { LevelEntity } from "./level.entity"
import { MealTypeEntity } from "./mealType.entity"
import { TagEntity } from "./tag.entity"

export class RecipeEntity
{
    public title: string = "";

    public description: string = "";

    public image: Uint8Array = new Uint8Array();

    public preparationType: number = 0.0;

    public calories: number = 0;

    public caloriesByPortion: number = 0;

    public ProteinByPortion: number = 0.0;

    public FatByPortion: number = 0.0;

    public CarbohydratesByPortion: number = 0.0;

    public PortionsCount: number = 0.0;

    public levelId: number = 0;

    public level: LevelEntity = new LevelEntity();

    public ingredients: Array<string> = [];

    public instructions: Array<string> = [];

    public tags: Array<TagEntity> = [];

    public mealTypes: Array<MealTypeEntity> = [];

    public categories: Array<CategoryEntity> = [];

    public comments: Array<CommentEntity> = [];
}