import { RecipeEntity } from "./recipe.entity"

export class CategoryEntity
{
    public name: string = "";

    public recipies: Array<RecipeEntity> = [];
}