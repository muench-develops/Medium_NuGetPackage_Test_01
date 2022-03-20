using Medium_NuGetPackage_Test_01.Features.Customer.GetAllCustomers;

namespace Medium_NuGetPackage_Test_01.Services.Customer;

public class CustomerService : ICustomerService
{
    public Task<List<Response>> GetCustomers()
    {
        return Task.FromResult(new List<Response>
        {
            new Response { CustomerNo = "cus1234", FirstName = "John", LastName = "Doe"},
            new Response { CustomerNo = "cus12345", FirstName = "John", LastName = "Doe"},
        });
    }
}