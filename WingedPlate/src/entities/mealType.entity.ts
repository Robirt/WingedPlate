import { RecipeEntity } from "./recipe.entity"

export class MealTypeEntity
{
    public name: string = "";

    public recipies: Array<RecipeEntity> = [];
}