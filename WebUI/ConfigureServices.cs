namespace WebUI;

public static class ConfigureServices
{
    public static IServiceCollection AddWebUIServices(this IServiceCollection services)
    {
        //services.AddSingleton<ICurrentUserService, CurrentUserService>();
        return services;
    }
}
