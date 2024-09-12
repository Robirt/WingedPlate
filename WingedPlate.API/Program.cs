using WingedPlate.API;
using WingedPlate.Infrastructure;

var webApplicationBuilder = WebApplication.CreateBuilder(args);

webApplicationBuilder.Services.AddCors(builder => builder.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

webApplicationBuilder.Services.AddRouting();

webApplicationBuilder.Services.AddAuthentication();

webApplicationBuilder.Services.AddAuthorization();

webApplicationBuilder.Services.AddDbContext<WingedPlateDbContext>();

webApplicationBuilder.Services.AddRepositories();

webApplicationBuilder.Services.AddServices();

webApplicationBuilder.Services.AddControllers();

var webApplication = webApplicationBuilder.Build();

webApplication.UseHttpsRedirection();

webApplication.UseCors();

webApplication.UseRouting();

webApplication.UseAuthentication();

webApplication.UseAuthorization();

webApplication.MapControllers();

webApplication.Run();
