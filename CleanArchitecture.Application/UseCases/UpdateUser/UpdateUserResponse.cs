using CleanArchitecture.Application.UseCases.CreateUser;


namespace CleanArchitecture.Application.UseCases.UpdateUser;

public record UpdateUserResponse 
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
}
