using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure;

public class WingedPlateDbContext : DbContext
{
    public WingedPlateDbContext() : base() 
    {
        
    }

    public WingedPlateDbContext(DbContextOptions<WingedPlateDbContext> options) : base(options) 
    {

    }

    public DbSet<RecipeEntity> Recipes { get; set; }

    public DbSet<CategoryEntity> Categories { get; set; } 

    public DbSet<CommentEntity> Comments { get; set; }

    public DbSet<LevelEntity> Levels { get; set; }

    public DbSet<MealTypeEntity> Meals { get; set; }    

    public DbSet<RoleEntity> Roles { get; set; }

    public DbSet<TagEntity> Tags { get; set; }

    public DbSet<UserEntity> Users { get; set; }    
}
