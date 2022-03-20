using Medium_NuGetPackage_Test_01.Features.Customer.GetAllCustomers;

namespace Medium_NuGetPackage_Test_01.Services.Customer;

public interface ICustomerService
{
    Task<List<Response>> GetCustomers();
}