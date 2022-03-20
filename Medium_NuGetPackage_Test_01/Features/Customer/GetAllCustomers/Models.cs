namespace Medium_NuGetPackage_Test_01.Features.Customer.GetAllCustomers;

public class Request
{
    public Guid Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CustomerNo { get; set; }
}

public class Response
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CustomerNo { get; set; }
}