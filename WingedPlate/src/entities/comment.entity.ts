import { RecipeEntity } from "./recipe.entity";
import { UserEntity } from "./user.entity";

export class CommentEntity
{
    public content: string = "";

    public userId: number = 0;

    public user: UserEntity = new UserEntity();

    public recipeId: number = 0;

    public recipe: RecipeEntity = new(RecipeEntity);
}