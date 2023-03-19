using Microsoft.EntityFrameworkCore;
using OrderApiApp.Model;
using OrderApiApp.Model.Entity;
using OrderApiApp.Service.ClientService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddTransient<IDaoClient, DbDaoClient>();
var app = builder.Build();

app.MapGet("/", () => "API is running!");

// обработчики тестирования бизнес-логики для работы с клиентом
app.MapGet("/client/all", async (IDaoClient daoClient) =>
{
    return await daoClient.GetAllAsync();
});

app.MapPost("/client/add", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.AddAsync(client);
});

app.Run();