using Microsoft.AspNetCore.Blazor.Hosting;

namespace BlazorWeather
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                //.UserUrls("http://192.168.0.32:63390")
                .UseBlazorStartup<Startup>();
    }
}
