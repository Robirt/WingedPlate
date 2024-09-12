using WingedPlate.Application.Services;
using WingedPlate.Infrastructure.Repositories;

namespace WingedPlate.API;

public static class ProgramExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICategoriesRepository, CategoriesRepository>();

        services.AddScoped<ICommentsRepository, CommentsRepository>();

        services.AddScoped<ILevelsRepository, LevelsRepository>();

        services.AddScoped<IMealTypesRepository, MealTypesRepository>();

        services.AddScoped<IRecipesRepository, RecipesRepository>();

        services.AddScoped<ITagsRepository, TagsRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoriesService, CategoriesService>();

        services.AddScoped<ICommentsService, CommentsService>();

        services.AddScoped<ILevelsService, LevelsService>();

        services.AddScoped<IMealTypesService, MealTypesService>();

        services.AddScoped<IRecipesService, RecipesService>();

        services.AddScoped<ITagsService, TagsService>();

        return services;
    }

}
