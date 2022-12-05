using CustomerManagament.Core.Handler.Implemetation;
using CustomerManagament.Core.Handler.Interface;
using CustomerManagament.Core.Models.DataBase;
using CustomerManagament.Core.Models.Request;
using CustomerManagament.Core.Repositories.Interfaces;
using CustomerManagament.Core.Utils.Mappers.Implementation;
using CustomerManagament.Core.Utils.Mappers.Interfaces;
using CustomerManagament.Infra.EntityFramework;
using CustomerManagament.Infra.Notification;
using CustomerManagament.Infra.Repositories;
using CustomerManagament.Infra.Repositories.Proxies;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
builder.Services
    .AddDbContext<CustomerInformationContext>(op => op.UseSqlServer(config.GetConnectionString("CustomerDb")));

var provider = builder.Services.BuildServiceProvider();

var context = provider.GetRequiredService<CustomerInformationContext>();
builder.Services.AddScoped<ICustomerRepository>
    (svc => new CustomerProxyRepository
    (new CustomerRepository(context), new NotifyCustomerUpdate(config)));

builder.Services.AddScoped<IMapper<CustomerRequest, Customer>, CustomerRequestToCustomerMapper>();
builder.Services.AddScoped<ICustomerHandler, CustomerHandler>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandlingMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();
