import { RecipeEntity } from "./recipe.entity"

export class TagEntity
{
    public name: string = "";

    public recipies: Array<RecipeEntity> = [];
}