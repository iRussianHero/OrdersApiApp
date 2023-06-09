using Microsoft.EntityFrameworkCore;
using OrderApiApp.Model;
using OrderApiApp.Model.Entity;
using OrderApiApp.Service.ClientService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddTransient<IDaoClient, DbDaoClient>();
var app = builder.Build();

app.MapGet("/", () => "API is running!");

// ����������� ������������ ������-������ ��� ������ � ��������
app.MapGet("/client/all", async (IDaoClient daoClient) =>
{
    return await daoClient.GetAllAsync();
});

app.MapPost("/client/add", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.AddAsync(client);
});

app.MapPost("/client/delete", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.DeleteAsync(client);
});

app.MapPost("/client/update", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.UpdateAsync(client);
});

app.MapPost("/client/choose", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.GetAsync(client);
});

app.Run();