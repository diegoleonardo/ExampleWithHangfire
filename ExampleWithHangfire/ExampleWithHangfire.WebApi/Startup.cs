using Microsoft.Owin;
using Owin;
using Hangfire;

[assembly: OwinStartup(typeof(ExampleWithHangfire.WebApi.Startup))]

namespace ExampleWithHangfire.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage(@"context's name ou connection string");
            
            // Path to access dashboard. Ex: localhost/jobs
            app.UseHangfireDashboard("/jobs");
            app.UseHangfireServer();
        }
    }
}
