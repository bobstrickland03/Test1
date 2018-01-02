using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddSolution.Startup))]
namespace AddSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
