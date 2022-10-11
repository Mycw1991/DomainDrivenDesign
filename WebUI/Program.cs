using Infrastructure;

namespace WebUI;

public static class Program
{
    public static void Main(string[] args)
    {
        var app = CreateHostBuilder(args).Build();

        if (!app.Services.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
        {
            app.Run();
            return;
        }
        
        using (var scope = app.Services.CreateScope())
        {
            var initialiser = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitializer>();
            initialiser.InitialiseAsync().Wait();
            initialiser.SeedAsync().Wait();
        }
        
        app.Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}