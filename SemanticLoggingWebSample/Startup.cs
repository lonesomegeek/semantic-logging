using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SemanticLoggingWebSample.Startup))]
namespace SemanticLoggingWebSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
