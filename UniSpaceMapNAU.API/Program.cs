using UniSpaceMapNAU.Application;
using UniSpaceMapNAU.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
/*builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});*/
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

/*app.UseAuthentication();
app.UseAuthorization();*/

app.MapControllers();

app.Run();
