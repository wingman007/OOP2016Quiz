using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kursovProekt.Startup))]
namespace kursovProekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
