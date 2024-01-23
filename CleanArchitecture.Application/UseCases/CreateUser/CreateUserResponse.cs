
//dto
namespace CleanArchitecture.Application.UseCases.CreateUser;

public  record CreateUserResponse
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
}
