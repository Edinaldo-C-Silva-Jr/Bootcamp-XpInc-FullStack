using MinimalsAPI;

public class Program
{
    private static void Main(string[] args)
    {
        IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartUp>();
                });
        }

        CreateHostBuilder(args).Build().Run();
    }
}