global using FastEndpoints;
global using FastEndpoints.Validation;
using FastEndpoints.Swagger;
using Medium_NuGetPackage_Test_01.Services.Customer;

var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();
builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();
app.UseAuthorization();
app.UseFastEndpoints();
app.UseOpenApi();
app.UseSwaggerUi3(c => c.ConfigureDefaults());
app.Run();