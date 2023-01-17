using ExerciseApi.Data;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Repository;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Service;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Repository;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Repository;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Service;
using ExerciseApi.Queries;
using ExerciseApi.EquipmentFeature.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextFactory<ExerciseApiDbContext>();
builder.Services.AddScoped<IEquipmentFetcherService, DefaultEquipmentFetcherService>();
builder.Services.AddScoped<IEquipmentFetcherRepository, DefaultEquipmentFetcherRepository>();
builder.Services.AddScoped<IEquipmentCreateService, DefaultEquipmentCreateService>();
builder.Services.AddScoped<IEquipmentCreateRepository, DefaultEquipmentCreateRepository>();
builder.Services.AddScoped<IEquipmentUpdateService, DefaultEquipmentUpdateService>();
builder.Services.AddScoped<IEquipmentUpdateRepository, DefaultEquipmentUpdateRepository>();
builder.Services.AddGraphQLServer()
    .RegisterDbContext<ExerciseApiDbContext>()
    .AddQueryType<Query>()
    .AddTypeExtension<EquipmentFetchQuery>();
    
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapGraphQL();
app.Run();

