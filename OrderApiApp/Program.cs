using Microsoft.EntityFrameworkCore;
using OrderApiApp.Model;
using OrderApiApp.Model.Entity;
using OrderApiApp.Service.ClientService;
using OrderApiApp.Service.OrderService;
using OrderApiApp.Service.ProductService;
using OrderApiApp.Service.ReceiptService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddTransient<IDaoClient, DbDaoClient>();
builder.Services.AddTransient<IDaoOrder, DbDaoOrder>();
builder.Services.AddTransient<IDaoProduct, DbDaoProduct>();
builder.Services.AddTransient<IDaoReceipt, DbDaoReceipt>();
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



app.MapGet("/order/all", async (IDaoOrder daoOrder) =>
{
    return await daoOrder.GetAllAsync();
});

app.MapPost("/order/add", async (Order order, IDaoOrder daoOrder) =>
{
    return await daoOrder.AddAsync(order);
});

app.MapPost("/order/delete", async (Order order, IDaoOrder daoOrder) =>
{
    return await daoOrder.DeleteAsync(order);
});

app.MapPost("/order/update", async (Order order, IDaoOrder daoOrder) =>
{
    return await daoOrder.UpdateAsync(order);
});

app.MapPost("/order/choose", async (Order order, IDaoOrder daoOrder) =>
{
    return await daoOrder.GetAsync(order);
});


app.MapGet("/product/all", async (IDaoProduct daoProduct) =>
{
    return await daoProduct.GetAllAsync();
});

app.MapPost("/product/add", async (Product product, IDaoProduct daoProduct) =>
{
    return await daoProduct.AddAsync(product);
});

app.MapPost("/product/delete", async (Product product, IDaoProduct daoProduct) =>
{
    return await daoProduct.DeleteAsync(product);
});

app.MapPost("/product/update", async (Product product, IDaoProduct daoProduct) =>
{
    return await daoProduct.UpdateAsync(product);
});

app.MapPost("/product/choose", async (Product product, IDaoProduct daoProduct) =>
{
    return await daoProduct.GetAsync(product);
});


app.MapGet("/receipt/all", async (IDaoReceipt daoReceipt) =>
{
    return await daoReceipt.GetAllAsync();
});

app.MapPost("/receipt/add", async (Receipt receipt, IDaoReceipt daoReceipt) =>
{
    return await daoReceipt.AddAsync(receipt);
});

app.MapPost("/receipt/delete", async (Receipt receipt, IDaoReceipt daoReceipt) =>
{
    return await daoReceipt.DeleteAsync(receipt);
});

app.MapPost("/receipt/update", async (Receipt receipt, IDaoReceipt daoReceipt) =>
{
    return await daoReceipt.UpdateAsync(receipt);
});

app.MapPost("/receipt/choose", async (Receipt receipt, IDaoReceipt daoReceipt) =>
{
    return await daoReceipt.GetAsync(receipt);
});


app.Run();