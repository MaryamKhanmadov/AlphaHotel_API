using AlphaHotel_API.Repository;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Service.Mappings;
using AlphaHotel_API.Service.Services;
using AlphaHotel_API.Service.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRepositoryLayerServices();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IRoomReadRepository, RoomReadRepository>();
builder.Services.AddScoped<IRoomWriteRepository, RoomWriteRepository>();
builder.Services.AddScoped<IRoomWriteService, RoomWriteService>();
builder.Services.AddScoped<IRoomReadService, RoomReadService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
