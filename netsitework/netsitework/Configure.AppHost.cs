using Funq;
using ServiceStack;
using netsitework.ServiceInterface;

[assembly: HostingStartup(typeof(netsitework.AppHost))]

namespace netsitework;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("netsitework", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        SetConfig(new HostConfig {
        });
    }
}
