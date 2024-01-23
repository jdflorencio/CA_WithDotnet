namespace CleanArchiteture.API.Extensions;

public static class CorsPolicyExtensions
{
    public static void COnfigureCorsPolicy(this IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddDefaultPolicy(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );
        });
    }
}
