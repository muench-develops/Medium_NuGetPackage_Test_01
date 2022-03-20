using Medium_NuGetPackage_Test_01.Services.Customer;

namespace Medium_NuGetPackage_Test_01.Features.Customer.GetAllCustomers;

public class Endpoint : EndpointWithoutRequest<List<Response>>
{
    private readonly ICustomerService _customerService;
    
    public Endpoint(ICustomerService customerService)
    {
        _customerService = customerService;
    }
    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/Customers/GetAllCustomers");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var customers = await _customerService.GetCustomers();

        await SendAsync(customers, cancellation: ct);
    }
}