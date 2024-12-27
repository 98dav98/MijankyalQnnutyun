using Microsoft.EntityFrameworkCore;
using MijankyalQnnutyun.DataSeeder;
using MijankyalQnnutyun.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DekanatDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.Configure<StudentsSeedDataSettings>(builder.Configuration.GetSection("SeedData"));
builder.Services.Configure<LearningSeedDataSettings>(builder.Configuration.GetSection("SeedData"));
builder.Services.Configure<FacultySeedDataSettings>(builder.Configuration.GetSection("SeedData"));
builder.Services.AddTransient<DataSeeder>();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataSeeder = scope.ServiceProvider.GetRequiredService<DataSeeder>();
    dataSeeder.SeedStudents();
    dataSeeder.SeedFaculties();
    dataSeeder.SeedLearnings();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
