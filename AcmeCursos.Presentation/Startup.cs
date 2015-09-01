using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcmeCursos.Presentation.Startup))]
namespace AcmeCursos.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
