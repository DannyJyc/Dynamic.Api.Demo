
using Dynamic.Api.Demo.Dynamic.Api.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// 调用扩展方法
builder.Services.AddControllers().AddDynamicWebApi();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
