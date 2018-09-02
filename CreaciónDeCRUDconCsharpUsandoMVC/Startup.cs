using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreaciónDeCRUDconCsharpUsandoMVC.Startup))]
namespace CreaciónDeCRUDconCsharpUsandoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
